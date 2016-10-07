using SixtenLabs.Spawn.CSharp;
using SixtenLabs.Spawn.Vulkan.Spec;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SixtenLabs.Spawn.CSharp.FluentDefinitions;

namespace SixtenLabs.Spawn.Vulkan
{
  public class ApiCreator : BaseCreator<VkRegistry, ClassDefinition>
  {
    public ApiCreator(ICodeGenerator generator, ISpawnSpec<VkRegistry> spawnSpec)
			: base(generator, spawnSpec, "API Creator", 5000)
		{
      // Try again after structs are created.
      //Off = true;
    }

    public override int Build(IMapper mapper)
    {
      int count = 0;

      var registryFeature = VulkanSpec.SpecTree.Feature.Requires;

      foreach (var registryRequires in registryFeature)
      {
        var classDefinition = mapper.Map<VkFeatureRequire, ClassDefinition>(registryRequires);

        foreach (var method in classDefinition.MethodDefinitions)
        {
          var command = VulkanSpec.SpecTree.Commands.Where(x => x.Name == method.Name.Original).FirstOrDefault();
          var commandDefinition = mapper.Map<VkCommand, MethodDefinition>(command);

          method.ReturnType = commandDefinition.ReturnType;
          method.ParameterDefinitions = commandDefinition.ParameterDefinitions;
          method.ModifierDefinitions = commandDefinition.ModifierDefinitions;
          method.Tag = commandDefinition.Tag;
          method.BlockDefinition = commandDefinition.BlockDefinition;
        }

        Definitions.Add(classDefinition);
        count++;
      }

      return count;
    }

    public override int Rewrite()
    {
      int count = 0;

      foreach(var classDefinition in Definitions)
      {
        foreach(var method in classDefinition.MethodDefinitions)
        {
          method.WithModifier(SyntaxKindDto.PublicKeyword);
          method.BlockDefinition = new BlockDefinition("body").WithStatement("throw new NotImplementedException();");
        }

        count++;
      }

      return count;
    }

    public override int Create()
    {
      int count = 0;

      foreach (var classDefinition in Definitions)
      {
        var output = new OutputDefinition() { FileName = $"VulkanApi{classDefinition.Name.Output}" };
        output.TargetSolution = TargetSolution;
        output.AddNamespace(TargetNamespace);
        output.AddStandardUsingDirective("System");
        output.OutputDirectory = "Api";
        output.Extension = "cs";

        classDefinition.WithModifiers(SyntaxKindDto.PublicKeyword, SyntaxKindDto.PartialKeyword);

        classDefinition.WithComment(classDefinition.Name.Output);
        classDefinition.Name.Translated = "VulkanApi";

        (Generator as CSharpGenerator).GenerateClass(output, classDefinition);
        count++;
      }

      return count;
    }
  }
}
