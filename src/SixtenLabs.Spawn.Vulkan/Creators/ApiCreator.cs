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
    }

    public override int Build(IMapper mapper)
    {
      int count = 0;

      var registryFeature = VulkanSpec.SpecTree.Feature.Requires;

      foreach (var registryRequires in registryFeature)
      {
        var classDefinition = mapper.Map<VkFeatureRequire, ClassDefinition>(registryRequires);

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
        classDefinition.Name.TranslatedName = VulkanSpec.GetTranslatedName(classDefinition.Name.OriginalName);

        count++;
      }

      return count;
    }

    public override int Create()
    {
      int count = 0;

      foreach (var classDefinition in Definitions)
      {
        var output = new OutputDefinition() { FileName = $"VulkanApi.{classDefinition.Name.Code}.cs" };
        output.TargetSolution = TargetSolution;
        output.AddNamespace(TargetNamespace);
        output.AddStandardUsingDirective("System");
        output.OutputDirectory = "";

        classDefinition.AddModifier(SyntaxKindDto.PublicKeyword);
        classDefinition.AddModifier(SyntaxKindDto.PartialKeyword);

        classDefinition.Comments.CommentLines.Add(classDefinition.Name.Code);
        classDefinition.Name.TranslatedName = "VulkanApi";

        (Generator as CSharpGenerator).GenerateClass(output, classDefinition);
        count++;
      }

      return count;
    }
  }
}
