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
      .ForMember(dest => dest.Name, opt => opt.MapFrom(m => new DefinitionName() { OriginalName = m.Comment }))
      .ForMember(dest => dest.SpecDerivedType, opt => opt.Ignore())
      .ForMember(dest => dest.Constructors, opt => opt.Ignore())
      .ForMember(dest => dest.Fields, opt => opt.Ignore())
      .ForMember(dest => dest.Properties, opt => opt.Ignore())
      .ForMember(dest => dest.Attributes, opt => opt.Ignore())
      .ForMember(dest => dest.DerivedType, opt => opt.Ignore())
      .ForMember(dest => dest.ModifierDefinitions, opt => opt.Ignore())
      .ForMember(dest => dest.Comments, opt => opt.Ignore())
      .ForMember(dest => dest.Tag, opt => opt.Ignore())
      .ForMember(dest => dest.Methods, opt => opt.Ignore());
    }
  }
}
