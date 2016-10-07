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
      var std = new SpecTypeDefinition();
      std.Name.Original = "string";
      std.Name.Translated = "string";
			VulkanSpec.DefinitionDictionary.AddSpecTypeDefinition(std);

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
				methodDefinition.Name.Translated = $"{VulkanSpec.DefinitionDictionary.GetTranslatedName(methodDefinition.Name.Original)}Delegate";
				methodDefinition.ReturnType.Translated = VulkanSpec.DefinitionDictionary.GetTranslatedName(methodDefinition.ReturnType.Original);
				methodDefinition.WithModifiers(SyntaxKindDto.PublicKeyword, SyntaxKindDto.DelegateKeyword);

				foreach (var parameter in methodDefinition.ParameterDefinitions)
				{
					parameter.IsPointer = false;
					parameter.ParameterType.Translated = VulkanSpec.DefinitionDictionary.GetTranslatedName(parameter.ParameterType.Original);
				}

				methodDefinition.WithAttribute("UnmanagedFunctionPointer", "CallingConvention.Winapi");

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
      output.Extension = "cs";

      foreach (var commentLine in GeneratedComments)
			{
				output.CommentLines.Add(commentLine);
			}

			var classDefinition = new ClassDefinition("Vk");
			classDefinition.Name.Translated = "Vk";
			classDefinition.WithModifiers(SyntaxKindDto.PublicKeyword, SyntaxKindDto.StaticKeyword, SyntaxKindDto.PartialKeyword);

			//var dllConstant = new FieldDefinition() { TranslatedName = "VulkanLibrary", TranslatedReturnType = "string", TranslatedValue = "vulkan-1.dll" };
			//dllConstant.AddModifier(SyntaxKindDto.PrivateKeyword);
			//dllConstant.AddModifier(SyntaxKindDto.ConstKeyword);
			//dllConstant.DefaultValue = new LiteralDefinition() { Value = "vulkan-1.dll", LiteralType = typeof(string) };
			//classDefinition.Fields.Add(dllConstant);

			classDefinition.MethodDefinitions = Definitions;

			output.AddStandardUsingDirective("System");
			output.AddStandardUsingDirective("System.Runtime.InteropServices");

			(Generator as CSharpGenerator).GenerateClass(output, classDefinition);
			count++;

			return count;
		}
	}
}
