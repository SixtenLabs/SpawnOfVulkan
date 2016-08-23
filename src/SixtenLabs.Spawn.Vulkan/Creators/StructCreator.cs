using AutoMapper;
using SixtenLabs.Spawn.CSharp;
using SixtenLabs.Spawn.Vulkan.Spec;
using System.Linq;
using SixtenLabs.Spawn.CSharp.FluentDefinitions;

namespace SixtenLabs.Spawn.Vulkan.Creators
{
	public class StructCreator : BaseCreator<VkRegistry, StructDefinition>
	{
		public StructCreator(ICodeGenerator generator, ISpawnSpec<VkRegistry> spawnSpec)
			: base(generator, spawnSpec, "Struct Creator", 40)
		{
			//Off = true;
		}

		public override int Rewrite()
		{
			int count = 0;

			foreach (var structDefinition in Definitions)
			{
				structDefinition.Name.TranslatedName = VulkanSpec.GetTranslatedName(structDefinition.Name.OriginalName);

				if (structDefinition.NeedsMarshalling)
				{
					structDefinition.WithModifiers(SyntaxKindDto.UnsafeKeyword, SyntaxKindDto.PublicKeyword);
				}
				else
				{
					structDefinition.WithModifier(SyntaxKindDto.PublicKeyword);
				}

				foreach (var fieldDefinition in structDefinition.FieldDefinitions)
				{
					fieldDefinition.WithModifier(SyntaxKindDto.InternalKeyword);

					if (fieldDefinition.ReturnTypeIsArray && structDefinition.Name.OriginalName != "VkImageBlit" && structDefinition.Name.OriginalName != "VkPhysicalDeviceMemoryProperties")
					{
						fieldDefinition.WithModifiers(SyntaxKindDto.UnsafeKeyword, SyntaxKindDto.FixedKeyword);

						var structx = VulkanSpec.SpecTree.Constants;
						var field = structx.Values.Where(x => x.Name == fieldDefinition.Tag).FirstOrDefault();

						string arraySize = null;

						if (field != null)
						{
							arraySize = field.Value;
						}
						else
						{
							arraySize = fieldDefinition.Tag;
						}

						fieldDefinition.ReturnType.TranslatedName = VulkanSpec.GetTranslatedName(fieldDefinition.ReturnType.OriginalName);
						fieldDefinition.Name.TranslatedName = $"{fieldDefinition.Name.OriginalName}[{arraySize}]";
					}
					else
					{
						fieldDefinition.ReturnType.TranslatedName = VulkanSpec.GetTranslatedName(fieldDefinition.ReturnType.OriginalName);
						fieldDefinition.Name.TranslatedName = VulkanSpec.GetTranslatedChildName(structDefinition.Name.OriginalName, fieldDefinition.Name.OriginalName);
					}
				}

				count++;
			}

			return count;
		}

		public override int Build(IMapper mapper)
		{
			var registryStructs = VulkanSpec.SpecTree.TypeStructs;

			foreach (var registryType in registryStructs)
			{
				var structDefinition = mapper.Map<VkTypeStruct, StructDefinition>(registryType);
				Definitions.Add(structDefinition);
			}

			return Definitions.Count;
		}

		public override int Create()
		{
			int count = 0;

			foreach (var structDefinition in Definitions)
			{
				var output = new OutputDefinition() { FileName = structDefinition.Name.TranslatedName };
				output.TargetSolution = TargetSolution;
        output.Extension = "cs";

        if (structDefinition.NeedsMarshalling)
				{
					output.AddNamespace($"{TargetNamespace}");
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
