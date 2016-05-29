using AutoMapper;
using SixtenLabs.Spawn.CSharp;
using SixtenLabs.Spawn.Vulkan.Spec;
using System.Linq;

namespace SixtenLabs.Spawn.Vulkan
{
	public class UnionCreator : BaseCreator<VkRegistry, StructDefinition>
	{
		public UnionCreator(ICodeGenerator generator, ISpawnSpec<VkRegistry> spawnSpec)
			: base(generator, spawnSpec, "Union Creator", 40)
		{
			//Off = true;
		}

		public override int Rewrite()
		{
			int count = 0;

			foreach (var structDefinition in Definitions)
			{
				structDefinition.TranslatedName = VulkanSpec.GetTranslatedName(structDefinition.SpecName);

				var attribute = new AttributeDefinition() { SpecName = "StructLayout" };
				attribute.ArgumentList.Add("LayoutKind.Explicit");

				structDefinition.Attributes.Add(attribute);

				if (!string.IsNullOrEmpty(structDefinition.SpecReturnType))
				{
					structDefinition.TranslatedReturnType = VulkanSpec.GetTranslatedName(structDefinition.SpecReturnType);
				}

				foreach (var fieldDefinition in structDefinition.Fields)
				{
					var fieldAttribute = new AttributeDefinition() { SpecName = "FieldOffset" };
					fieldAttribute.ArgumentList.Add("0");

					fieldDefinition.Attributes.Add(fieldAttribute);

					if (fieldDefinition.ReturnTypeIsArray)
					{
						var translatedName = VulkanSpec.GetTranslatedChildName(structDefinition.SpecName, fieldDefinition.SpecName);
						fieldDefinition.TranslatedName = $"{translatedName}[{fieldDefinition.Tag}]";
						fieldDefinition.TranslatedReturnType = VulkanSpec.GetTranslatedName(fieldDefinition.SpecReturnType);
						fieldDefinition.AddModifier(SyntaxKindDto.InternalKeyword);
						fieldDefinition.AddModifier(SyntaxKindDto.UnsafeKeyword);
						fieldDefinition.AddModifier(SyntaxKindDto.FixedKeyword);
					}
					else
					{
						fieldDefinition.TranslatedReturnType = VulkanSpec.GetTranslatedName(fieldDefinition.SpecReturnType);
						fieldDefinition.AddModifier(SyntaxKindDto.InternalKeyword);
					}
				}

				count++;
			}

			return count;
		}

		public override int Build(IMapper mapper)
		{
			var unions = VulkanSpec.SpecTree.TypeUnions;

			foreach (var union in unions)
			{
				var structDefinition = mapper.Map<VkTypeUnion, StructDefinition>(union);
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
				output.OutputDirectory = "Unions";
				output.AddStandardUsingDirective("System.Runtime.InteropServices");
				structDefinition.AddModifier(SyntaxKindDto.PublicKeyword);
				
				(Generator as CSharpGenerator).GenerateStruct(output, structDefinition);
				count++;
			}

			return count;
		}
	}
}
