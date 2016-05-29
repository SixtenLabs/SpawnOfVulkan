using AutoMapper;
using SixtenLabs.Spawn.CSharp;
using SixtenLabs.Spawn.Vulkan.Spec;
using System.Linq;

namespace SixtenLabs.Spawn.Vulkan
{
	public class ConstantsCreator : BaseCreator<VkRegistry, ClassDefinition>
	{
		public ConstantsCreator(ICodeGenerator generator, ISpawnSpec<VkRegistry> spawnSpec)
			: base(generator, spawnSpec, "Constants Creator", 9)
		{
		}

		private void AddExtensions(ClassDefinition classDefinition)
		{
			var extEnumValues = VulkanSpec.SpecTree.Extensions.SelectMany(x => x.Enums).Where(x => x.Extends == null && x.Value != x.Name);

			foreach (var enumValue in extEnumValues)
			{
				int valueInt;
				var isInt = int.TryParse(enumValue.Value, out valueInt);
				var value = new LiteralDefinition() { Value = enumValue.Value, LiteralType = isInt ? typeof(int) : typeof(string) };
				var fieldDef = new FieldDefinition() { SpecName = enumValue.Name, DefaultValue = value, SpecReturnType = isInt ? "int" : "string" };
				
				classDefinition.Fields.Add(fieldDef);
			}
		}

		public override int Build(IMapper mapper)
		{
			var registryConstants = VulkanSpec.SpecTree.Constants;

			var classDefinition = mapper.Map<VkConstant, ClassDefinition>(VulkanSpec.SpecTree.Constants);

			classDefinition.AddModifier(SyntaxKindDto.PublicKeyword);
			classDefinition.AddModifier(SyntaxKindDto.StaticKeyword);
			classDefinition.SpecName = VulkanSpec.SpecTree.Constants.Name;
			
			// This is hardcoded for this single enum exception.
			classDefinition.TranslatedName = "ApiConstants";

			AddExtensions(classDefinition);

			Definitions.Add(classDefinition);
	
			return Definitions.Count;
		}

		public override int Rewrite()
		{
			int count = 0;

			foreach(var classDefinition in Definitions)
			{
				foreach(var fieldDefinition in classDefinition.Fields)
				{
					fieldDefinition.TranslatedName = VulkanSpec.GetTranslatedName(fieldDefinition.SpecName);
					fieldDefinition.AddModifier(SyntaxKindDto.PublicKeyword);
					fieldDefinition.AddModifier(SyntaxKindDto.ConstKeyword);
				}

				count++;
			}

			return count;
		}

		public override int Create()
		{
			int count = 0;

			foreach (var classDefintion in Definitions)
			{
				var output = new OutputDefinition() { FileName = classDefintion.TranslatedName };
				output.TargetSolution = TargetSolution;
				output.AddNamespace(TargetNamespace);
				output.OutputDirectory = "Constants";

				foreach (var commentLine in GeneratedComments)
				{
					output.CommentLines.Add(commentLine);
				}

				//foreach (var commentLine in classDefintion.Comments)
				//{
				//	output.CommentLines.Add(commentLine);
				//}

				output.AddStandardUsingDirective("System");

				(Generator as CSharpGenerator).GenerateClass(output, classDefintion);
				count++;
			}

			return count;
		}
	}
}
