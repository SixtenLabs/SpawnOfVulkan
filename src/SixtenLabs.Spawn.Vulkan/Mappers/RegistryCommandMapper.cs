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
				.ForMember(dest => dest.SpecName, opt => opt.MapFrom(m => m.Name))
				.ForMember(dest => dest.SpecReturnType, opt => opt.MapFrom(m => m.Type))
				.ForMember(dest => dest.Parameters, opt => opt.MapFrom(m => m.Parameters))
				.ForMember(dest => dest.Attributes, opt => opt.Ignore())
				.ForMember(dest => dest.SpecType, opt => opt.Ignore())
				.ForMember(dest => dest.TranslatedType, opt => opt.Ignore())
				.ForMember(dest => dest.SpecValue, opt => opt.Ignore())
				.ForMember(dest => dest.TranslatedValue, opt => opt.Ignore())
				.ForMember(dest => dest.Block, opt => opt.Ignore())
				.ForMember(dest => dest.TranslatedReturnType, opt => opt.Ignore())
				.ForMember(dest => dest.ModifierDefinitions, opt => opt.Ignore())
				.ForMember(dest => dest.TranslatedName, opt => opt.Ignore())
				.ForMember(dest => dest.Tag, opt => opt.Ignore());

			CreateMap<VkCommandParameter, ParameterDefinition>()
				.ForMember(dest => dest.SpecName, opt => opt.MapFrom(m => m.Name))
				.ForMember(dest => dest.IsPointer, opt => opt.MapFrom(m => m.PointerRank > 0))
				.ForMember(dest => dest.SpecReturnType, opt => opt.MapFrom(m => MapReturnType(m.ReturnType)))
				.ForMember(dest => dest.TranslatedReturnType, opt => opt.Ignore())
				.ForMember(dest => dest.ModifierDefinitions, opt => opt.Ignore())
				.ForMember(dest => dest.TranslatedName, opt => opt.Ignore())
				.ForMember(dest => dest.Tag, opt => opt.Ignore());
		}

		private string MapReturnType(string returnType)
		{
			if(returnType == "char")
			{
				return "string";
			}
			else
			{
				return returnType;
			}

		}
	}
}
