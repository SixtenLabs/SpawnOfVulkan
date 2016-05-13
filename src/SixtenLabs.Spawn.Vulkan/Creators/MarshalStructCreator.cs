using AutoMapper;
using SixtenLabs.Spawn.CSharp;
using SixtenLabs.Spawn.Utility;
using System;
using System.Linq;

namespace SixtenLabs.Spawn.Vulkan.Creators
{
	public class MarshalStructCreator : BaseCreator<registry, StructDefinition>
	{
		public MarshalStructCreator(ICodeGenerator generator, ISpawnSpec<registry> spawnSpec)
			: base(generator, spawnSpec, 40)
		{
			//Off = true;
		}

		public override int Rewrite()
		{
			int count = 0;

			foreach (var structDefinition in Definitions)
			{
				structDefinition.TranslatedName = VulkanSpec.GetTranslatedName(structDefinition.SpecName);

				if (structDefinition.NeedsMarshalling)
				{
					structDefinition.AddModifier(SyntaxKindDto.UnsafeKeyword);
					structDefinition.AddModifier(SyntaxKindDto.InternalKeyword);
				}
				else
				{
					structDefinition.AddModifier(SyntaxKindDto.PublicKeyword);
				}

				if (!string.IsNullOrEmpty(structDefinition.SpecReturnType))
				{
					structDefinition.TranslatedReturnType = VulkanSpec.GetTranslatedName(structDefinition.SpecReturnType);
				}

				foreach (var fieldDefinition in structDefinition.Fields)
				{
					fieldDefinition.AddModifier(SyntaxKindDto.InternalKeyword);

					if (fieldDefinition.ReturnTypeIsArray && structDefinition.SpecName != "VkImageBlit" && structDefinition.SpecName != "VkPhysicalDeviceMemoryProperties")
					{
						fieldDefinition.AddModifier(SyntaxKindDto.UnsafeKeyword);
						fieldDefinition.AddModifier(SyntaxKindDto.FixedKeyword);

						var structx = VulkanSpec.SpecTree.enums.Where(x => x.name == "API Constants").FirstOrDefault();
						var field = structx.@enum.Where(x => x.name == fieldDefinition.Tag).FirstOrDefault();

						string arraySize = null;

						if (field != null)
						{
							arraySize = field.value;
						}
						else
						{
							arraySize = fieldDefinition.Tag;
						}

						fieldDefinition.TranslatedReturnType = VulkanSpec.GetTranslatedName(fieldDefinition.SpecReturnType);
						fieldDefinition.TranslatedName = $"{fieldDefinition.TranslatedName}[{arraySize}]";
					}
					else
					{
						fieldDefinition.TranslatedReturnType = VulkanSpec.GetTranslatedName(fieldDefinition.SpecReturnType);
					}
				}

				count++;
			}

			return count;
		}

		public override int Build(IMapper mapper)
		{
			var registryStructs = VulkanSpec.SpecTree.types.Where(x => x.category == "struct");

			foreach (var registryType in registryStructs)
			{
				var structDefinition = mapper.Map<registryType, StructDefinition>(registryType);
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

				if (structDefinition.NeedsMarshalling)
				{
					output.AddNamespace($"{TargetNamespace}.Interop");
					output.OutputDirectory = "Interop";
				}
				else
				{
					output.AddNamespace(TargetNamespace);
					output.OutputDirectory = "Structs";
				}

				output.AddStandardUsingDirective("System");

				foreach (var commentLine in GeneratedComments)
				{
					output.CommentLines.Add(commentLine);
				}

				(Generator as CSharpGenerator).GenerateStruct(output, structDefinition);
				count++;
			}

			return count;
		}
	}
}
