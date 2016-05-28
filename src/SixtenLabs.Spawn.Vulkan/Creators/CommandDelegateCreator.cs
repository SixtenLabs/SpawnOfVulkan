using AutoMapper;
using SixtenLabs.Spawn.CSharp;
using SixtenLabs.Spawn.Vulkan.Spec;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixtenLabs.Spawn.Vulkan.Creators
{
	public class CommandDelegateCreator : BaseCreator<VkRegistry, MethodDefinition>
	{
		public CommandDelegateCreator(ICodeGenerator generator, ISpawnSpec<VkRegistry> spawnSpec)
			: base(generator, spawnSpec, "Command Delegate Creator", 80)
		{
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
				methodDefinition.TranslatedName = $"{VulkanSpec.GetTranslatedName(methodDefinition.SpecName)}Delegate";
				methodDefinition.TranslatedReturnType = VulkanSpec.GetTranslatedName(methodDefinition.SpecReturnType);
				methodDefinition.AddModifier(SyntaxKindDto.PublicKeyword);
				methodDefinition.AddModifier(SyntaxKindDto.DelegateKeyword);

				foreach (var parameter in methodDefinition.Parameters)
				{
					parameter.IsPointer = false;
					parameter.TranslatedReturnType = VulkanSpec.GetTranslatedName(parameter.SpecReturnType);
				}

				var attribute = new AttributeDefinition() { SpecName = "UnmanagedFunctionPointer", TranslatedName = "UnmanagedFunctionPointer" };
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

			var classDefinition = new ClassDefinition() { SpecName = "Vk" };
			classDefinition.TranslatedName = "Vk";
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
