using AutoMapper;
using SixtenLabs.Spawn.CSharp;
using SixtenLabs.Spawn.Vulkan.Spec;

namespace SixtenLabs.Spawn.Vulkan
{
	public class RegistryCommandMapper : Profile
	{
		protected override void Configure()
		{
			CreateMap<VkCommand, MethodDefinition>()
				.ForMember(dest => dest.SpecName, opt => opt.MapFrom(m => m.Name))
				.ForMember(dest => dest.SpecReturnType, opt => opt.MapFrom(m => m.Type))
				//.ForMember(dest => dest.Comments, opt => opt.MapFrom(m => GetComments(m)))
				.ForMember(dest => dest.Parameters, opt => opt.MapFrom(m => m.Parameters));

			CreateMap<VkCommandParameter, ParameterDefinition>()
				.ForMember(dest => dest.SpecName, opt => opt.MapFrom(m => m.Name))
				//.ForMember(dest => dest.ExternSync, opt => opt.MapFrom(m => m.externsync == "true"))
				//.ForMember(dest => dest.IsOptional, opt => opt.MapFrom(m => m.optional == "true"))
				.ForMember(dest => dest.IsPointer, opt => opt.MapFrom(m => m.PointerRank > 0))
				//.ForMember(dest => dest.IsConst, opt => opt.MapFrom(m => IsConst(m.Text)))
				.ForMember(dest => dest.SpecReturnType, opt => opt.MapFrom(m => MapReturnType(m.ReturnType)));
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
