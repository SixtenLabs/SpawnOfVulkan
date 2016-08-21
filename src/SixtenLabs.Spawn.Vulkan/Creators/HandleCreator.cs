using AutoMapper;
using SixtenLabs.Spawn.CSharp;
using SixtenLabs.Spawn.Vulkan.Spec;
using SixtenLabs.Spawn.CSharp.FluentDefinitions;

namespace SixtenLabs.Spawn.Vulkan
{
	public class HandleCreator : BaseCreator<VkRegistry, StructDefinition>
	{
		public HandleCreator(ICodeGenerator generator, ISpawnSpec<VkRegistry> spawnSpec)
			: base(generator, spawnSpec, "Handle Creator", 20)
		{
		}

		public override int Rewrite()
		{
			int count = 0;

			foreach(var definition in Definitions)
			{
				definition.Name.TranslatedName = VulkanSpec.GetTranslatedName(definition.Name.OriginalName);
				definition.DerivedType = VulkanSpec.GetTranslatedName(definition.Name.OriginalName);

				var nativePointer = new FieldDefinition("nativePointer").WithReturnType("IntPtr");
				var fieldOffset = new AttributeDefinition("FieldOffset") { ArgumentList = new[] { "0" } };
				nativePointer.AttributeDefinitions.Add(fieldOffset);
				nativePointer.AddModifier(SyntaxKindDto.PublicKeyword);

				definition.Fields.Add(nativePointer);

        var defaultValue = new LiteralDefinition(definition.Name.TranslatedName) { Kind = SyntaxKindDto.ObjectCreationExpression };
        defaultValue.Arguments.Add(new ArgumentDefinition("IntPtr.Zero"));
        var nullProperty = new FieldDefinition("Null").WithReturnType(definition.Name.TranslatedName).WithDefaultValue(defaultValue);
				nullProperty.AddModifier(SyntaxKindDto.PublicKeyword);
				nullProperty.AddModifier(SyntaxKindDto.ReadOnlyKeyword);
				nullProperty.AddModifier(SyntaxKindDto.StaticKeyword);

				definition.Fields.Add(nullProperty);

        var constructor = new ConstructorDefinition(definition.Name.Code);
        constructor.AddModifier(SyntaxKindDto.PrivateKeyword);
        constructor.AddCodeLineToBody("this.nativePointer = nativePointer;");
        constructor.AddParameter("nativePointer", "IntPtr");

        definition.Constructors.Add(constructor);

        count++;
			}
			
			return 0;
		}

		public override int Build(IMapper mapper)
		{
			var registryHandles = VulkanSpec.SpecTree.Handles;

			foreach (var registryHandle in registryHandles)
			{
				var structDefinition = mapper.Map<VkTypeHandle, StructDefinition>(registryHandle);
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
				output.AddNamespace(TargetNamespace);
				output.AddStandardUsingDirective("System");
				output.AddStandardUsingDirective("System.Runtime.InteropServices");
				output.OutputDirectory = "Handles";

				foreach (var commentLine in GeneratedComments)
				{
					output.CommentLines.Add(commentLine);
				}

				structDefinition.Attributes.Add(new AttributeDefinition("StructLayout") { ArgumentList = new[] { "LayoutKind.Explicit" } });
				structDefinition.AddModifier(SyntaxKindDto.PublicKeyword);

				(Generator as CSharpGenerator).GenerateStruct(output, structDefinition);
				count++;
			}

			return count;
		}
	}
}
