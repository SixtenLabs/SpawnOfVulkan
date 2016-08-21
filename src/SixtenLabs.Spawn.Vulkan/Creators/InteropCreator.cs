using AutoMapper;
using SixtenLabs.Spawn.CSharp;
using SixtenLabs.Spawn.Vulkan.Spec;
using SixtenLabs.Spawn.CSharp.FluentDefinitions;

namespace SixtenLabs.Spawn.Vulkan.Creators
{
	public class NativeMethodsCreator : BaseCreator<VkRegistry, MethodDefinition>
	{
		public NativeMethodsCreator(ICodeGenerator generator, ISpawnSpec<VkRegistry> spawnSpec)
			: base(generator, spawnSpec, "Interop Creator", 30)
		{
			Off = true;
		}

		public override int Build(IMapper mapper)
		{
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
				methodDefinition.Name.TranslatedName = VulkanSpec.GetTranslatedName(methodDefinition.Name.OriginalName);
				methodDefinition.ReturnType.TranslatedName = VulkanSpec.GetTranslatedName(methodDefinition.ReturnType.OriginalName);
				methodDefinition.AddModifier(SyntaxKindDto.InternalKeyword);
				methodDefinition.AddModifier(SyntaxKindDto.StaticKeyword);
				methodDefinition.AddModifier(SyntaxKindDto.UnsafeKeyword);
				methodDefinition.AddModifier(SyntaxKindDto.ExternKeyword);

				foreach(var parameter in methodDefinition.Parameters)
				{
					parameter.ParameterType.TranslatedName = VulkanSpec.GetTranslatedName(parameter.ParameterType.OriginalName);
				}

				var attribute = new AttributeDefinition("DllImport");
				attribute.ArgumentList.Add("VulkanLibrary");
				attribute.ArgumentList.Add("CallingConvention = CallingConvention.StdCall");
				methodDefinition.Attributes.Add(attribute);

				count++;
			}

			return count;
		}

		public override int Create()
		{
			int count = 0;

			var output = new OutputDefinition() { FileName = "NativeMethods" };
			output.TargetSolution = TargetSolution;
			output.AddNamespace($"{TargetNamespace}");
			output.OutputDirectory = "Interop";
			
			foreach (var commentLine in GeneratedComments)
			{
				output.CommentLines.Add(commentLine);
			}

			var classDefinition = new ClassDefinition("NativeMethods");
			classDefinition.Name.TranslatedName = "NativeMethods";
			classDefinition.AddModifier(SyntaxKindDto.InternalKeyword);
			classDefinition.AddModifier(SyntaxKindDto.StaticKeyword);
      
      var defaulValue = new LiteralDefinition("VulkanLibrary") { Value = "vulkan-1.dll", LiteralType = typeof(string) };
      var dllConstant = new FieldDefinition("VulkanLibrary").WithReturnType("string").WithDefaultValue(defaulValue);
			dllConstant.AddModifier(SyntaxKindDto.PrivateKeyword);
			dllConstant.AddModifier(SyntaxKindDto.ConstKeyword);
      classDefinition.Fields.Add(dllConstant);

			classDefinition.Methods.AddRange(Definitions);

			output.AddStandardUsingDirective("System");
			output.AddStandardUsingDirective("System.Runtime.InteropServices");

			(Generator as CSharpGenerator).GenerateClass(output, classDefinition);
			count++;

			return count;
		}
	}
}
