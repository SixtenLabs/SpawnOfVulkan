using AutoMapper;
using SixtenLabs.Spawn.CSharp;

namespace SixtenLabs.Spawn.Vulkan
{
	public class RegistryFeatureMapper : Profile
	{
		protected override void Configure()
		{
			//CreateMap<registryFeature, ClassDefinition>()
				//.ForMember(dest => dest.SpecName, opt => opt.MapFrom(m => m.name));
				//.ForMember(dest => dest.SpecReturnType, opt => opt.MapFrom(m => m.proto.type))
				//.ForMember(dest => dest.Comments, opt => opt.MapFrom(m => GetComments(m)))
				//.ForMember(dest => dest.Parameters, opt => opt.MapFrom(m => m.param));
		}
	}
}
