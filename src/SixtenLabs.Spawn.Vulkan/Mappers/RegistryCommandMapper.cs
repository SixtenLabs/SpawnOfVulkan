using AutoMapper;
using SixtenLabs.Spawn.CSharp;
using SixtenLabs.Spawn.Vulkan.Spec;

namespace SixtenLabs.Spawn.Vulkan
{
	public class RegistryCommandMapper : Profile
	{
		public RegistryCommandMapper()
		{
			ConfigureMaps();
		}

		private void ConfigureMaps()
		{
			CreateMap<VkCommand, MethodDefinition>()
        .ForMember(dest => dest.Name, opt => opt.MapFrom(m => m.Name))
        .ForMember(dest => dest.ReturnType, opt => opt.MapFrom(m => m.Type))
				.ForMember(dest => dest.ParameterDefinitions, opt => opt.MapFrom(m => m.Parameters))
				.ForMember(dest => dest.AttributeDefinitions, opt => opt.Ignore())
				.ForMember(dest => dest.BlockDefinition, opt => opt.Ignore())
				.ForMember(dest => dest.ModifierDefinitions, opt => opt.Ignore())
				.ForMember(dest => dest.Tag, opt => opt.Ignore());

			CreateMap<VkCommandParameter, ParameterDefinition>()
				.ForMember(dest => dest.Name, opt => opt.MapFrom(m => m.Name))
				.ForMember(dest => dest.IsPointer, opt => opt.MapFrom(m => m.PointerRank > 0))
        .ForMember(dest => dest.ParameterType, opt => opt.MapFrom(m => m.ReturnType))
        .ForMember(dest => dest.Tag, opt => opt.Ignore());
		}
	}
}
