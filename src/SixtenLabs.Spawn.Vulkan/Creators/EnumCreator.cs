﻿using System.Linq;
using AutoMapper;
using SixtenLabs.Spawn.CSharp;
using SixtenLabs.Spawn.Vulkan.Spec;

namespace SixtenLabs.Spawn.Vulkan
{
	public class EnumCreator : BaseCreator<VkRegistry, EnumDefinition>
	{
		public EnumCreator(ICodeGenerator generator, ISpawnSpec<VkRegistry> spawnSpec)
			: base(generator, spawnSpec, "Enum Creator", 10)
		{
			Off = true;
		}

		public override int Build(IMapper mapper)
		{
			var registryEnums = VulkanSpec.SpecTree.Enums;

			foreach(var registryEnum in registryEnums)
			{
				var enumDefinition = mapper.Map<VkEnum, EnumDefinition>(registryEnum);
				Definitions.Add(enumDefinition);
			}

			return Definitions.Count;
		}

		public override int Rewrite()
		{
			int count = 0;

			foreach (var enumDefinition in Definitions)
			{
				enumDefinition.TranslatedName = VulkanSpec.GetTranslatedName(enumDefinition.SpecName);
				enumDefinition.BaseType = SyntaxKindDto.IntKeyword;

				foreach (var valueDefinition in enumDefinition.Members)
				{
					valueDefinition.TranslatedName = VulkanSpec.GetTranslatedName(valueDefinition.SpecName);
				}

				count++;
			}

			return count;
		}

		public override int Create()
		{
			int count = 0;

			foreach (var enumDefinition in Definitions)
			{
				var output = new OutputDefinition() { FileName = enumDefinition.TranslatedName };
				output.TargetSolution = TargetSolution;
				output.AddNamespace(TargetNamespace);
				output.OutputDirectory = "Enums";

				enumDefinition.AddModifier(SyntaxKindDto.PublicKeyword);

				foreach (var commentLine in GeneratedComments)
				{
					output.CommentLines.Add(commentLine);
				}

				//foreach (var commentLine in enumDefinition.Comments)
				//{
				//	output.CommentLines.Add(commentLine);
				//}

				if (enumDefinition.HasFlags)
				{
					output.AddStandardUsingDirective("System");
				}

				(Generator as CSharpGenerator).GenerateEnum(output, enumDefinition);
				count++;
			}

			return count;
		}
	}
}
