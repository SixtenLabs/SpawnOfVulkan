using AutoMapper;
using SixtenLabs.Spawn.Vulkan.Spec;
using System.Linq;

namespace SixtenLabs.Spawn.Vulkan
{
  public class VulkanSpecMapper : SpecMapper<VkRegistry>
  {
    public VulkanSpecMapper(IDefinitionDictionary definitionDictionary)
    {
      DefinitionDictionary = definitionDictionary;
    }

    private void MapRequireTypes(IMapper mapper, VkRegistry registry)
    {
      var intPtrSpecTypeDefinition = new SpecTypeDefinition();
      intPtrSpecTypeDefinition.Name.Original = "IntPtr";
      DefinitionDictionary.AddSpecTypeDefinition(intPtrSpecTypeDefinition);

      var byteSpecTypeDefinition = new SpecTypeDefinition();
      byteSpecTypeDefinition.Name.Original = "byte";
      DefinitionDictionary.AddSpecTypeDefinition(byteSpecTypeDefinition);

      var floatSpecTypeDefinition = new SpecTypeDefinition();
      floatSpecTypeDefinition.Name.Original = "float";
      DefinitionDictionary.AddSpecTypeDefinition(floatSpecTypeDefinition);

      var uintSpecTypeDefinition = new SpecTypeDefinition();
      uintSpecTypeDefinition.Name.Original = "uint";
      DefinitionDictionary.AddSpecTypeDefinition(uintSpecTypeDefinition);

      var intSpecTypeDefinition = new SpecTypeDefinition();
      intSpecTypeDefinition.Name.Original = "int";
      DefinitionDictionary.AddSpecTypeDefinition(intSpecTypeDefinition);

      var ulongSpecTypeDefinition = new SpecTypeDefinition();
      ulongSpecTypeDefinition.Name.Original = "ulong";
      DefinitionDictionary.AddSpecTypeDefinition(ulongSpecTypeDefinition);

      var uIntPtrSpecTypeDefinition = new SpecTypeDefinition();
      uIntPtrSpecTypeDefinition.Name.Original = "UIntPtr";
      DefinitionDictionary.AddSpecTypeDefinition(uIntPtrSpecTypeDefinition);
    }

    private void MapConstants(IMapper mapper, VkRegistry registry)
    {
      var constSpecTypeDefinition = mapper.Map<VkConstant, SpecTypeDefinition>(registry.Constants);
      DefinitionDictionary.AddSpecTypeDefinition(constSpecTypeDefinition);
    }

    private void MapConstantsValues(IMapper mapper, VkRegistry registry)
    {
      foreach (var regType in registry.Constants.Values)
      {
        var specTypeDefinition = mapper.Map<VkConstantValue, SpecTypeDefinition>(regType);
        DefinitionDictionary.AddSpecTypeDefinition(specTypeDefinition);
      }
    }

    private void MapRequires(IMapper mapper, VkRegistry registry)
    {
      foreach (var regRequires in registry.Requires)
      {
        var specTypeDefinition = mapper.Map<VkTypeRequires, SpecTypeDefinition>(regRequires);
        DefinitionDictionary.AddSpecTypeDefinition(specTypeDefinition);
      }
    }

    private void MapBaseTypes(IMapper mapper, VkRegistry registry)
    {
      foreach (var regBaseType in registry.BaseTypes)
      {
        var specTypeDefinition = mapper.Map<VkTypeBaseType, SpecTypeDefinition>(regBaseType);
        DefinitionDictionary.AddSpecTypeDefinition(specTypeDefinition);
      }
    }

    private void MapBitmasks(IMapper mapper, VkRegistry registry)
    {
      foreach (var regBitmask in registry.Bitmasks)
      {
        var specTypeDefinition = mapper.Map<VkTypeBitmask, SpecTypeDefinition>(regBitmask);
        DefinitionDictionary.AddSpecTypeDefinition(specTypeDefinition);
      }
    }

    private void MapTypeFuncPointers(IMapper mapper, VkRegistry registry)
    {
      foreach (var regFuncPointer in registry.TypeFuncPointers)
      {
        var specTypeDefinition = mapper.Map<VkTypeFuncPointer, SpecTypeDefinition>(regFuncPointer);

        foreach (var regStructMember in regFuncPointer.Parameters)
        {
          var specMemberDefinition = mapper.Map<VkTypeFuncPointerParameter, SpecTypeDefinition>(regStructMember);
          specTypeDefinition.Children.Add(specMemberDefinition);
        }

        DefinitionDictionary.AddSpecTypeDefinition(specTypeDefinition);
      }
    }

    private void MapTypeStructs(IMapper mapper, VkRegistry registry)
    {
      foreach (var regStruct in registry.TypeStructs)
      {
        var specTypeDefinition = mapper.Map<VkTypeStruct, SpecTypeDefinition>(regStruct);

        foreach (var regStructMember in regStruct.Members)
        {
          var specMemberDefinition = mapper.Map<VkTypeStructMember, SpecTypeDefinition>(regStructMember);
          specTypeDefinition.Children.Add(specMemberDefinition);
        }

        DefinitionDictionary.AddSpecTypeDefinition(specTypeDefinition);
      }
    }

    private void MapTypeUnions(IMapper mapper, VkRegistry registry)
    {
      foreach (var regUnion in registry.TypeUnions)
      {
        var specTypeDefinition = mapper.Map<VkTypeUnion, SpecTypeDefinition>(regUnion);

        foreach (var regUnionMember in regUnion.Members)
        {
          var specMemberDefinition = mapper.Map<VkTypeUnionMember, SpecTypeDefinition>(regUnionMember);
          specTypeDefinition.Children.Add(specMemberDefinition);
        }

        DefinitionDictionary.AddSpecTypeDefinition(specTypeDefinition);
      }
    }

    private void MapHandles(IMapper mapper, VkRegistry registry)
    {
      foreach (var regType in registry.Handles)
      {
        var specTypeDefinition = mapper.Map<VkTypeHandle, SpecTypeDefinition>(regType);
        DefinitionDictionary.AddSpecTypeDefinition(specTypeDefinition);
      }
    }

    private void MapTypeEnums(IMapper mapper, VkRegistry registry)
    {
      foreach (var regType in registry.TypeEnums)
      {
        var specTypeDefinition = mapper.Map<VkTypeEnum, SpecTypeDefinition>(regType);
        DefinitionDictionary.AddSpecTypeDefinition(specTypeDefinition);
      }
    }

    private void MapTypeEnumValues(IMapper mapper, VkRegistry registry)
    {
      foreach (var enumValueType in registry.Enums.SelectMany(x => x.Values))
      {
        var specTypeDefinition = mapper.Map<VkEnumValue, SpecTypeDefinition>(enumValueType);
        DefinitionDictionary.AddSpecTypeDefinition(specTypeDefinition);
      }
    }

    private void MapCommands(IMapper mapper, VkRegistry registry)
    {
      foreach (var regCommand in registry.Commands)
      {
        var specTypeDefinition = mapper.Map<VkCommand, SpecTypeDefinition>(regCommand);
        DefinitionDictionary.AddSpecTypeDefinition(specTypeDefinition);
      }
    }

    private void MapExtensions(IMapper mapper, VkRegistry registry)
    {
      foreach (var regExtension in registry.Extensions)
      {
        var specTypeDefinition = mapper.Map<VkExtension, SpecTypeDefinition>(regExtension);
        DefinitionDictionary.AddSpecTypeDefinition(specTypeDefinition);
      }
    }

    private void MapCommandExtensions(IMapper mapper, VkRegistry registry)
    {
      foreach (var regExtension in registry.Extensions)
      {
        foreach (var extCommand in regExtension.Commands)
        {
          var specTypeDefinition = mapper.Map<VkExtensionCommand, SpecTypeDefinition>(extCommand);
          DefinitionDictionary.AddSpecTypeDefinition(specTypeDefinition);
        }
      }
    }

    private void MapTypeExtensions(IMapper mapper, VkRegistry registry)
    {
      foreach (var regExtension in registry.Extensions)
      {
        foreach (var extType in regExtension.Types)
        {
          var specTypeDefinition = mapper.Map<VkExtensionType, SpecTypeDefinition>(extType);
          DefinitionDictionary.AddSpecTypeDefinition(specTypeDefinition);
        }
      }
    }

    private void MapEnumExtensions(IMapper mapper, VkRegistry registry)
    {
      foreach (var regExtension in registry.Extensions)
      {
        foreach (var extEnum in regExtension.Enums)
        {
          var specTypeDefinition = mapper.Map<VkExtensionEnum, SpecTypeDefinition>(extEnum);
          DefinitionDictionary.AddSpecTypeDefinition(specTypeDefinition);
        }
      }
    }

    private void MapFeatures(IMapper mapper, VkRegistry registry)
    {
      foreach (var featureRequire in registry.Feature.Requires)
      {
        var specTypeDefinition = mapper.Map<VkFeatureRequire, SpecTypeDefinition>(featureRequire);
        DefinitionDictionary.AddSpecTypeDefinition(specTypeDefinition);

        foreach (var requireCommand in featureRequire.Commands)
        {
          var specTypeDefinitionCommand = mapper.Map<VkFeatureRequireCommand, SpecTypeDefinition>(requireCommand);
          DefinitionDictionary.AddSpecTypeDefinition(specTypeDefinitionCommand);
        }

        foreach (var requireType in featureRequire.Types)
        {
          var specTypeDefinitionType = mapper.Map<VkFeatureRequireType, SpecTypeDefinition>(requireType);
          DefinitionDictionary.AddSpecTypeDefinition(specTypeDefinitionType);
        }

        foreach (var requireEnum in featureRequire.Enums)
        {
          var specTypeDefinitionEnum = mapper.Map<VkFeatureRequireEnum, SpecTypeDefinition>(requireEnum);
          DefinitionDictionary.AddSpecTypeDefinition(specTypeDefinitionEnum);
        }
      }
    }

    public override void MapSpecTypes(IMapper mapper, VkRegistry registry)
    {
      MapRequireTypes(mapper, registry);
      MapConstants(mapper, registry);
      MapConstantsValues(mapper, registry);
      MapRequires(mapper, registry);
      MapBaseTypes(mapper, registry);
      MapBitmasks(mapper, registry);
      MapTypeFuncPointers(mapper, registry);
      MapTypeStructs(mapper, registry);
      MapTypeUnions(mapper, registry);
      MapHandles(mapper, registry);
      MapTypeEnums(mapper, registry);
      MapTypeEnumValues(mapper, registry);
      MapCommands(mapper, registry);
      MapExtensions(mapper, registry);
      MapCommandExtensions(mapper, registry);
      MapTypeExtensions(mapper, registry);
      MapEnumExtensions(mapper, registry);
      MapFeatures(mapper, registry);
    }

    private IDefinitionDictionary DefinitionDictionary { get; }
  }
}
