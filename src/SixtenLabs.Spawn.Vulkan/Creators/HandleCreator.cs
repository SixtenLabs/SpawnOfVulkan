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

    public override int Rewrite()
		{
			int count = 0;

			foreach(var definition in Definitions)
			{
        definition
          .AddField("nativePointer")
          .WithReturnType("IntPtr")
          .WithAttribute("FieldOffset", "0")
          .WithModifier(SyntaxKindDto.PublicKeyword);

        definition.AddField("Null")
          .WithReturnType(definition.Name.Output)
          .WithDefaultValue(definition.Name.Output, typeof(string), SyntaxKindDto.ObjectCreationExpression, "IntPtr.Zero")
          .WithModifiers(SyntaxKindDto.PublicKeyword, SyntaxKindDto.ReadOnlyKeyword, SyntaxKindDto.StaticKeyword);

        definition.AddConstructor(definition.Name.Output)
          .WithModifier(SyntaxKindDto.PrivateKeyword)
          .WithParameter("nativePointer", "IntPtr")
          .AddBlock("body")
          .WithStatement("this.nativePointer = nativePointer;");

        count++;
			}
			
			return count;
		}

		public override int Create()
		{
			int count = 0;

			foreach (var structDefinition in Definitions)
			{
				var output = new OutputDefinition() { FileName = structDefinition.Name.Output };
				output.TargetSolution = TargetSolution;
				output.AddNamespace(TargetNamespace);
				output.AddStandardUsingDirective("System");
				output.AddStandardUsingDirective("System.Runtime.InteropServices");
				output.OutputDirectory = "Handles";
        output.Extension = "cs";

        foreach (var commentLine in GeneratedComments)
				{
					output.CommentLines.Add(commentLine);
				}

				structDefinition
          .WithModifier(SyntaxKindDto.PublicKeyword)
          .WithAttribute("StructLayout", "LayoutKind.Explicit");

				(Generator as CSharpGenerator).GenerateStruct(output, structDefinition);
				count++;
			}

			return count;
		}
	}
}
