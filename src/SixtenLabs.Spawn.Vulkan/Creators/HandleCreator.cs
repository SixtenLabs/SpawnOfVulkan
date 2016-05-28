using AutoMapper;
using SixtenLabs.Spawn.CSharp;
using SixtenLabs.Spawn.Vulkan.Spec;
using System.Linq;

namespace SixtenLabs.Spawn.Vulkan
{
	public class HandleCreator : BaseCreator<VkRegistry, ClassDefinition>
	{
		public HandleCreator(ICodeGenerator generator, ISpawnSpec<VkRegistry> spawnSpec)
			: base(generator, spawnSpec, "Handle Creator", 20)
		{
			Off = true;
		}

		public override int Rewrite()
		{
			int count = 0;

			foreach(var structDefinition in Definitions)
			{
				structDefinition.TranslatedName = VulkanSpec.GetTranslatedName(structDefinition.SpecName);
				structDefinition.DerivedType = VulkanSpec.GetTranslatedName(structDefinition.SpecName);

				count++;
			}
			
			return 0;
		}

		public override int Build(IMapper mapper)
		{
			var registryHandles = VulkanSpec.SpecTree.Handles;

			foreach (var registryHandle in registryHandles)
			{
				var structDefinition = mapper.Map<VkTypeHandle, ClassDefinition>(registryHandle);
				Definitions.Add(structDefinition);
			}

			return Definitions.Count;
		}

		public override int Create()
		{
			int count = 0;

			foreach (var structDefinition in Definitions)
			{
				var output = new OutputDefinition() { FileName = structDefinition.TranslatedName };
				output.TargetSolution = TargetSolution;
				output.AddNamespace(TargetNamespace);
				output.OutputDirectory = "Handles";

				foreach (var commentLine in GeneratedComments)
				{
					output.CommentLines.Add(commentLine);
				}

				structDefinition.AddModifier(SyntaxKindDto.PublicKeyword);

				//foreach (var commentLine in classDefintion.Comments)
				//{
				//	output.CommentLines.Add(commentLine);
				//}

				output.AddStandardUsingDirective("System");

				(Generator as CSharpGenerator).GenerateClass(output, structDefinition);
				count++;
			}

			return count;
		}
	}
}
