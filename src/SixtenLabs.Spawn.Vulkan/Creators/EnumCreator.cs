using System.Linq;
using AutoMapper;
using SixtenLabs.Spawn.CSharp;
using SixtenLabs.Spawn.Vulkan.Spec;
using SixtenLabs.Spawn.CSharp.FluentDefinitions;
using System;

namespace SixtenLabs.Spawn.Vulkan
{
	public class EnumCreator : BaseCreator<VkRegistry, EnumDefinition>
	{
		public EnumCreator(ICodeGenerator generator, ISpawnSpec<VkRegistry> spawnSpec)
			: base(generator, spawnSpec, "Enum Creator", 10)
		{
		}

		private string GetExtensionEnumValueValue(string extNum, VkExtensionEnum extEnum)
		{
			string value = null;

			string extNumber = (int.Parse(extNum) - 1).ToString();

			if (!string.IsNullOrEmpty(extEnum.Offset))
			{
				var baseValue = "100000";
				value = $"{baseValue}{extNumber}00{extEnum.Offset}";

				if (!string.IsNullOrEmpty(extEnum.Dir))
				{
					value = $"{extEnum.Dir}{value}";
				}
			}
			else if (!string.IsNullOrEmpty(extEnum.BitPos))
			{
				value = extEnum.BitPos.FormatFlagValue();
			}
			else
			{
				value = extEnum.Value;
			}

			return value;
		}

		private EnumMemberDefinition GetExtensionEnumValue(VkExtensionEnum extEnum, VkExtension parent)
		{
			EnumMemberDefinition extensionEnumDefinition = new EnumMemberDefinition(extEnum.Name);
			extensionEnumDefinition.Value = GetExtensionEnumValueValue(parent.Number, extEnum);

			return extensionEnumDefinition;
		}

		private void GetExtensions(EnumDefinition enumDef)
		{
			var extEnumValues = VulkanSpec.SpecTree.Extensions.SelectMany(x => x.Enums).Where(x => x.Extends == enumDef.Name.Original);
			
			foreach(var enumValue in extEnumValues)
			{
				var parentExtension = VulkanSpec.SpecTree.Extensions.Where(x => x.Enums.Contains(enumValue)).FirstOrDefault();

				var enumMemberDef = GetExtensionEnumValue(enumValue, parentExtension);

				enumDef.Members.Add(enumMemberDef);
			}
		}

		public override int Build(IMapper mapper)
		{
			var registryEnums = VulkanSpec.SpecTree.Enums;

			foreach (var registryEnum in registryEnums)
			{
				var enumDefinition = mapper.Map<VkEnum, EnumDefinition>(registryEnum);
				GetExtensions(enumDefinition);
				Definitions.Add(enumDefinition);
			}

			var vkFlagsEnums = VulkanSpec.SpecTree.Bitmasks.Where(x => x.Type == "VkFlags");

			foreach (var vkFlagsEnum in vkFlagsEnums)
			{
        var isEnum = Definitions.Any(x => x.Name.Original == vkFlagsEnum.Requires);

        if (!isEnum)
        {
          var enumDefinition = new EnumDefinition(vkFlagsEnum.Name).WithComment("vkFlag");
          enumDefinition.AddEnumMember("None").WithValue("0");

          Definitions.Add(enumDefinition);
        }
			}

			return Definitions.Count;
		}

		private void SetBaseType(EnumDefinition enumDefinition)
		{
			if (enumDefinition.Members.Any(x => x.Value.Length > 10))
			{
				enumDefinition.BaseType = SyntaxKindDto.LongKeyword;
			}
			else
			{
				enumDefinition.BaseType = SyntaxKindDto.IntKeyword;
			}

		}

		public override int Rewrite()
		{
			int count = 0;

			foreach (var enumDefinition in Definitions)
			{
				SetBaseType(enumDefinition);

        if(enumDefinition.HasFlags)
        {
          enumDefinition.WithFlagsAttribute();
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
				var output = new OutputDefinition() { FileName = enumDefinition.Name.Output };
				output.TargetSolution = TargetSolution;
				output.AddNamespace(TargetNamespace);
				output.OutputDirectory = "Enums";
        output.Extension = "cs";

        enumDefinition.WithModifier(SyntaxKindDto.PublicKeyword);

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
