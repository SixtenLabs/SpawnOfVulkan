using System.Linq;
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

		private string GetExtensionEnumValueValue(string extNum, VkExtensionEnum extEnum)
		{
			string value = null;

			string extNumber = (int.Parse(extNum) - 1).ToString();

			if(!string.IsNullOrEmpty(extEnum.Offset))
			{
				var baseValue = "100000";
				value = $"{baseValue}{extNumber}00{extEnum.Offset}";

				if(!string.IsNullOrEmpty(extEnum.Dir))
				{
					value = $"{extEnum.Dir}{value}";
				}
			}
			else
			{
				value = extEnum.Value;
			}

			return value;
		}

		private EnumMemberDefinition GetExtensionEnumValue(VkExtensionEnum extEnum)
		{
			EnumMemberDefinition extensionEnumDefinition = new EnumMemberDefinition();

			// need parent extension name to get the number from the extension not the original enum.
			var extNumber = VulkanSpec.SpecTree.Extensions.Where(x => x.Name == extEnum.Extends).FirstOrDefault().Number;

			extensionEnumDefinition.SpecName = extEnum.Name;
			extensionEnumDefinition.Value = GetExtensionEnumValueValue(extNumber, extEnum);

			return extensionEnumDefinition;
		}

		private void GetExtensions(EnumDefinition enumDef)
		{
			var extEnumValues = VulkanSpec.SpecTree.Extensions.SelectMany(x => x.Enums).Where(x => x.Extends == enumDef.SpecName);

			foreach(var enumValue in extEnumValues)
			{
				var enumMemberDef = GetExtensionEnumValue(enumValue);

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
