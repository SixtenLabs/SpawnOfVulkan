﻿using AutoMapper;
using SixtenLabs.Spawn.CSharp;
using SixtenLabs.Spawn.Vulkan.Spec;
using System.Linq;
using SixtenLabs.Spawn.CSharp.FluentDefinitions;

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
				structDefinition.Name.TranslatedName = VulkanSpec.GetTranslatedName(structDefinition.Name.OriginalName);

				structDefinition.WithAttribute("StructLayout", "LayoutKind.Explicit");

				foreach (var fieldDefinition in structDefinition.FieldDefinitions)
				{
					fieldDefinition.WithAttribute("FieldOffset", "0");

					if (fieldDefinition.ReturnTypeIsArray)
					{
						var translatedName = VulkanSpec.GetTranslatedChildName(structDefinition.Name.OriginalName, fieldDefinition.Name.OriginalName);
						fieldDefinition.Name.TranslatedName = $"{translatedName}[{fieldDefinition.Tag}]";
						fieldDefinition.ReturnType.TranslatedName = VulkanSpec.GetTranslatedName(fieldDefinition.ReturnType.OriginalName);
						fieldDefinition.WithModifiers(SyntaxKindDto.InternalKeyword, SyntaxKindDto.UnsafeKeyword, SyntaxKindDto.FixedKeyword);
					}
					else
					{
						fieldDefinition.ReturnType.TranslatedName = VulkanSpec.GetTranslatedName(fieldDefinition.ReturnType.OriginalName);
						fieldDefinition.WithModifier(SyntaxKindDto.InternalKeyword);
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
				var output = new OutputDefinition() { FileName = structDefinition.Name.Code };
				output.TargetSolution = TargetSolution;
				output.AddNamespace(TargetNamespace);
				output.OutputDirectory = "Unions";
        output.Extension = "cs";
        output.AddStandardUsingDirective("System.Runtime.InteropServices");
				structDefinition.WithModifier(SyntaxKindDto.PublicKeyword);
				
				(Generator as CSharpGenerator).GenerateStruct(output, structDefinition);
				count++;
			}

			return count;
		}
	}
}
