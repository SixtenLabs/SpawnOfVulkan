using AutoMapper;
using SixtenLabs.Spawn.CSharp;
using SixtenLabs.Spawn.Vulkan.Spec;
using SixtenLabs.Spawn.CSharp.FluentDefinitions;

namespace SixtenLabs.Spawn.Vulkan.Creators
{
	public class CommandDelegateCreator : BaseCreator<VkRegistry, MethodDefinition>
	{
		public CommandDelegateCreator(ICodeGenerator generator, ISpawnSpec<VkRegistry> spawnSpec)
			: base(generator, spawnSpec, "Command Delegate Creator", 80)
		{
			//Off = true;
		}

		public override int Build(IMapper mapper)
		{
			VulkanSpec.AddSpecTypeDefinition(new SpecTypeDefinition() { SpecName = "string", TranslatedName = "string" });

			var registryCommands = VulkanSpec.SpecTree.Commands;

			foreach (var registryEnum in registryCommands)
			{
				var commandDefinition = mapper.Map<VkCommand, MethodDefinition>(registryEnum);
				Definitions.Add(commandDefinition);
			}

			return Definitions.Count;
		}

		public override int Rewrite()
		{
			int count = 0;

			foreach (var methodDefinition in Definitions)
			{
				methodDefinition.Name.TranslatedName = $"{VulkanSpec.GetTranslatedName(methodDefinition.Name.OriginalName)}Delegate";
				methodDefinition.ReturnType.TranslatedName = VulkanSpec.GetTranslatedName(methodDefinition.ReturnType.OriginalName);
				methodDefinition.AddModifier(SyntaxKindDto.PublicKeyword);
				methodDefinition.AddModifier(SyntaxKindDto.DelegateKeyword);

				foreach (var parameter in methodDefinition.Parameters)
				{
					parameter.IsPointer = false;
					parameter.ParameterType.TranslatedName = VulkanSpec.GetTranslatedName(parameter.ParameterType.OriginalName);
				}

				var attribute = new AttributeDefinition("UnmanagedFunctionPointer");
				attribute.ArgumentList.Add("CallingConvention.Winapi");
				methodDefinition.Attributes.Add(attribute);

				count++;
			}

			return count;
		}

		public override int Create()
		{
			int count = 0;

			var output = new OutputDefinition() { FileName = "VkDelegates" };
			output.TargetSolution = TargetSolution;
			output.AddNamespace($"{TargetNamespace}");
			output.OutputDirectory = "Interop";

			foreach (var commentLine in GeneratedComments)
			{
				output.CommentLines.Add(commentLine);
			}

			var classDefinition = new ClassDefinition("Vk");
			classDefinition.Name.TranslatedName = "Vk";
			classDefinition.AddModifier(SyntaxKindDto.PublicKeyword);
			classDefinition.AddModifier(SyntaxKindDto.StaticKeyword);
			classDefinition.AddModifier(SyntaxKindDto.PartialKeyword);

			//var dllConstant = new FieldDefinition() { TranslatedName = "VulkanLibrary", TranslatedReturnType = "string", TranslatedValue = "vulkan-1.dll" };
			//dllConstant.AddModifier(SyntaxKindDto.PrivateKeyword);
			//dllConstant.AddModifier(SyntaxKindDto.ConstKeyword);
			//dllConstant.DefaultValue = new LiteralDefinition() { Value = "vulkan-1.dll", LiteralType = typeof(string) };
			//classDefinition.Fields.Add(dllConstant);

			classDefinition.Methods.AddRange(Definitions);

			output.AddStandardUsingDirective("System");
			output.AddStandardUsingDirective("System.Runtime.InteropServices");

			(Generator as CSharpGenerator).GenerateClass(output, classDefinition);
			count++;

			return count;
		}
	}
}
