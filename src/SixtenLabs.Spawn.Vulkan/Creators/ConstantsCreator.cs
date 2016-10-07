using AutoMapper;
using SixtenLabs.Spawn.CSharp;
using SixtenLabs.Spawn.Vulkan.Spec;
using System.Linq;
using SixtenLabs.Spawn.CSharp.FluentDefinitions;

namespace SixtenLabs.Spawn.Vulkan
{
	public class ConstantsCreator : BaseCreator<VkRegistry, ClassDefinition>
	{
		public ConstantsCreator(ICodeGenerator generator, ISpawnSpec<VkRegistry> spawnSpec)
			: base(generator, spawnSpec, "Constants Creator", 9)
		{
      Off = true;
		}

		private void AddExtensions(ClassDefinition classDefinition)
		{
			var extEnumValues = VulkanSpec.SpecTree.Extensions.SelectMany(x => x.Enums).Where(x => x.Extends == null && x.Value != x.Name);

			foreach (var enumValue in extEnumValues)
			{
				int valueInt;
				var isInt = int.TryParse(enumValue.Value, out valueInt);
					classDefinition.AddField(enumValue.Name).WithDefaultValue(enumValue.Value, isInt ? typeof(int) : typeof(string), SyntaxKindDto.None).WithReturnType(isInt ? "int" : "string");
      }
		}

		public override int Build(IMapper mapper)
		{
			var registryConstants = VulkanSpec.SpecTree.Constants;

			var classDefinition = mapper.Map<VkConstant, ClassDefinition>(VulkanSpec.SpecTree.Constants);

			classDefinition.WithModifiers(SyntaxKindDto.PublicKeyword, SyntaxKindDto.StaticKeyword);
			classDefinition.Name.Original = VulkanSpec.SpecTree.Constants.Name;
			
			// This is hardcoded for this single enum exception.
			classDefinition.Name.Translated = "ApiConstants";

			AddExtensions(classDefinition);

			Definitions.Add(classDefinition);
	
			return Definitions.Count;
		}

		public override int Rewrite()
		{
			int count = 0;

			foreach(var classDefinition in Definitions)
			{
				foreach(var fieldDefinition in classDefinition.FieldDefinitions)
				{
					fieldDefinition.WithModifiers(SyntaxKindDto.PublicKeyword, SyntaxKindDto.ConstKeyword);

					if(fieldDefinition.ReturnType.Translated == null)
					{
						fieldDefinition.ReturnType.Translated = fieldDefinition.ReturnType.Original;
					}
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
				var output = new OutputDefinition() { FileName = classDefintion.Name.Translated };
				output.TargetSolution = TargetSolution;
				output.AddNamespace(TargetNamespace);
				output.OutputDirectory = "Constants";
        output.Extension = "cs";

        foreach (var commentLine in GeneratedComments)
				{
					output.CommentLines.Add(commentLine);
				}

				//foreach (var commentLine in classDefintion.Comments)
				//{
				//	output.CommentLines.Add(commentLine);
				//}

				output.AddStandardUsingDirective("System");

				var results = classDefintion.FieldDefinitions.Where(x => x.ReturnType.Translated == null);
        // One of the literals is null. figure out which one.
				(Generator as CSharpGenerator).GenerateClass(output, classDefintion);
				count++;
			}

			return count;
		}
	}
}
