using AutoMapper;
using SixtenLabs.Spawn.CSharp;
using SixtenLabs.Spawn.Vulkan.Spec;

namespace SixtenLabs.Spawn.Vulkan
{
	public class RegistryFeatureMapper : Profile
	{
    public RegistryFeatureMapper()
    {
      ConfigureMap();
    }

    protected void ConfigureMap()
    {
      CreateMap<VkFeatureRequire, ClassDefinition>()
      .ForMember(dest => dest.Name, opt => opt.MapFrom(m => m.Comment))
      .ForMember(dest => dest.MethodDefinitions, opt => opt.MapFrom(m => m.Commands))
      .ForMember(dest => dest.DerivedType, opt => opt.Ignore())
      .ForMember(dest => dest.ConstructorDefinitions, opt => opt.Ignore())
      .ForMember(dest => dest.FieldDefinitions, opt => opt.Ignore())
      .ForMember(dest => dest.PropertyDefinitions, opt => opt.Ignore())
      .ForMember(dest => dest.AttributeDefinitions, opt => opt.Ignore())
      .ForMember(dest => dest.DerivedType, opt => opt.Ignore())
      .ForMember(dest => dest.ModifierDefinitions, opt => opt.Ignore())
      .ForMember(dest => dest.DocumentationCommentDefinition, opt => opt.Ignore())
      .ForMember(dest => dest.Tag, opt => opt.Ignore())
      .ForMember(dest => dest.InterfaceDefinitions, opt => opt.Ignore());

      CreateMap<VkFeatureRequireCommand, MethodDefinition>()
      .ForMember(dest => dest.Name, opt => opt.MapFrom(m => m.Name))
      .ForMember(dest => dest.AttributeDefinitions, opt => opt.Ignore())
      .ForMember(dest => dest.ModifierDefinitions, opt => opt.Ignore())
      .ForMember(dest => dest.ReturnType, opt => opt.Ignore())
      .ForMember(dest => dest.BlockDefinition, opt => opt.Ignore())
      .ForMember(dest => dest.ParameterDefinitions, opt => opt.Ignore())
      .ForMember(dest => dest.Tag, opt => opt.Ignore());
    }
  }
}
