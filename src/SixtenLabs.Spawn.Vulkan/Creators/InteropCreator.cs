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
				methodDefinition.WithModifiers(SyntaxKindDto.InternalKeyword, SyntaxKindDto.StaticKeyword, SyntaxKindDto.UnsafeKeyword, SyntaxKindDto.ExternKeyword);
	
				foreach(var parameter in methodDefinition.ParameterDefinitions)
				{
					parameter.ParameterType.TranslatedName = VulkanSpec.GetTranslatedName(parameter.ParameterType.OriginalName);
				}

        methodDefinition.WithAttribute("DllImport", "VulkanLibrary", "CallingConvention = CallingConvention.StdCall");

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
      output.Extension = "cs";

      foreach (var commentLine in GeneratedComments)
			{
				output.CommentLines.Add(commentLine);
			}

			var classDefinition = new ClassDefinition("NativeMethods");
			classDefinition.Name.TranslatedName = "NativeMethods";
			classDefinition.WithModifiers(SyntaxKindDto.InternalKeyword, SyntaxKindDto.StaticKeyword);

      classDefinition.AddField("VulkanLibrary")
        .WithDefaultValue("VulkanLibrary", typeof(string), SyntaxKindDto.None)
        .WithModifiers(SyntaxKindDto.PrivateKeyword, SyntaxKindDto.ConstKeyword);

			//classDefinition.Methods.AddRange(Definitions);

			output.AddStandardUsingDirective("System");
			output.AddStandardUsingDirective("System.Runtime.InteropServices");

			(Generator as CSharpGenerator).GenerateClass(output, classDefinition);
			count++;

			return count;
		}
	}
}
