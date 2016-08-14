using AutoMapper;
using SixtenLabs.Spawn.CSharp;
using SixtenLabs.Spawn.Vulkan.Spec;
using System.Linq;

namespace SixtenLabs.Spawn.Vulkan
{
	public class RegistryTypeMapper : Profile
	{
		public RegistryTypeMapper()
		{
			ConfigureMaps();
		}

		private void ConfigureStructs()
		{
			CreateMap<VkTypeStruct, StructDefinition>()
				.ForMember(dest => dest.SpecName, opt => opt.MapFrom(m => m.Name))
				.ForMember(dest => dest.Fields, opt => opt.MapFrom(m => m.Members))
				.ForMember(dest => dest.SpecDerivedType, opt => opt.Ignore())
				.ForMember(dest => dest.DerivedType, opt => opt.Ignore())
				.ForMember(dest => dest.NeedsMarshalling, opt => opt.Ignore())
				.ForMember(dest => dest.Attributes, opt => opt.Ignore())
				.ForMember(dest => dest.Comments, opt => opt.Ignore())
				.ForMember(dest => dest.SpecReturnType, opt => opt.Ignore())
				.ForMember(dest => dest.TranslatedReturnType, opt => opt.Ignore())
				.ForMember(dest => dest.ModifierDefinitions, opt => opt.Ignore())
				.ForMember(dest => dest.TranslatedName, opt => opt.Ignore())
				.ForMember(dest => dest.Tag, opt => opt.Ignore());

			CreateMap<VkTypeStructMember, FieldDefinition>()
				.ForMember(dest => dest.SpecName, opt => opt.MapFrom(m => m.Name))
				.ForMember(dest => dest.SpecReturnType, opt => opt.MapFrom(m => m.ReturnType))
				.ForMember(dest => dest.ReturnTypeIsArray, opt => opt.MapFrom(m => m.IsArray))
				.ForMember(dest => dest.Tag, opt => opt.MapFrom(m => m.ArrayCount))
				.ForMember(dest => dest.SpecType, opt => opt.MapFrom(m => m.ReturnType))
				.ForMember(dest => dest.DefaultValue, opt => opt.Ignore())
				.ForMember(dest => dest.ArraySize, opt => opt.Ignore())
				.ForMember(dest => dest.Attributes, opt => opt.Ignore())
				.ForMember(dest => dest.TranslatedType, opt => opt.Ignore())
				.ForMember(dest => dest.SpecValue, opt => opt.Ignore())
				.ForMember(dest => dest.TranslatedType, opt => opt.Ignore())
				.ForMember(dest => dest.Parameters, opt => opt.Ignore())
				.ForMember(dest => dest.Block, opt => opt.Ignore())
				.ForMember(dest => dest.TranslatedReturnType, opt => opt.Ignore())
				.ForMember(dest => dest.ModifierDefinitions, opt => opt.Ignore())
				.ForMember(dest => dest.TranslatedValue, opt => opt.Ignore())
				.ForMember(dest => dest.TranslatedName, opt => opt.Ignore());
		}

		private void ConfigureUnions()
		{
			CreateMap<VkTypeUnion, StructDefinition>()
				.ForMember(dest => dest.SpecName, opt => opt.MapFrom(m => m.Name))
				.ForMember(dest => dest.Fields, opt => opt.MapFrom(m => m.Members))
				.ForMember(dest => dest.SpecDerivedType, opt => opt.Ignore())
				.ForMember(dest => dest.DerivedType, opt => opt.Ignore())
				.ForMember(dest => dest.NeedsMarshalling, opt => opt.Ignore())
				.ForMember(dest => dest.Attributes, opt => opt.Ignore())
				.ForMember(dest => dest.Comments, opt => opt.Ignore())
				.ForMember(dest => dest.SpecReturnType, opt => opt.Ignore())
				.ForMember(dest => dest.TranslatedReturnType, opt => opt.Ignore())
				.ForMember(dest => dest.ModifierDefinitions, opt => opt.Ignore())
				.ForMember(dest => dest.TranslatedName, opt => opt.Ignore())
				.ForMember(dest => dest.Tag, opt => opt.Ignore());

			CreateMap<VkTypeUnionMember, FieldDefinition>()
				.ForMember(dest => dest.SpecName, opt => opt.MapFrom(m => m.Name))
				.ForMember(dest => dest.SpecReturnType, opt => opt.MapFrom(m => m.ReturnType))
				.ForMember(dest => dest.ReturnTypeIsArray, opt => opt.MapFrom(m => m.IsArray))
				.ForMember(dest => dest.Tag, opt => opt.MapFrom(m => m.ArrayCount))
				.ForMember(dest => dest.SpecType, opt => opt.MapFrom(m => m.ReturnType))
				.ForMember(dest => dest.DefaultValue, opt => opt.Ignore())
				.ForMember(dest => dest.ArraySize, opt => opt.Ignore())
				.ForMember(dest => dest.Attributes, opt => opt.Ignore())
				.ForMember(dest => dest.TranslatedType, opt => opt.Ignore())
				.ForMember(dest => dest.SpecValue, opt => opt.Ignore())
				.ForMember(dest => dest.TranslatedType, opt => opt.Ignore())
				.ForMember(dest => dest.Parameters, opt => opt.Ignore())
				.ForMember(dest => dest.Block, opt => opt.Ignore())
				.ForMember(dest => dest.TranslatedReturnType, opt => opt.Ignore())
				.ForMember(dest => dest.ModifierDefinitions, opt => opt.Ignore())
				.ForMember(dest => dest.TranslatedValue, opt => opt.Ignore())
				.ForMember(dest => dest.TranslatedName, opt => opt.Ignore());
		}

		private void ConfigureHandles()
		{
			CreateMap<VkTypeHandle, ClassDefinition>()
				.ForMember(dest => dest.SpecName, opt => opt.MapFrom(m => m.Name))
				.ForMember(dest => dest.SpecDerivedType, opt => opt.MapFrom(m => m.Parent))
				.ForMember(dest => dest.DerivedType, opt => opt.Ignore())
				.ForMember(dest => dest.Methods, opt => opt.Ignore())
				.ForMember(dest => dest.Attributes, opt => opt.Ignore())
				.ForMember(dest => dest.Comments, opt => opt.Ignore())
				.ForMember(dest => dest.SpecReturnType, opt => opt.Ignore())
				.ForMember(dest => dest.TranslatedReturnType, opt => opt.Ignore())
				.ForMember(dest => dest.ModifierDefinitions, opt => opt.Ignore())
				.ForMember(dest => dest.TranslatedName, opt => opt.Ignore())
				.ForMember(dest => dest.Fields, opt => opt.Ignore())
				.ForMember(dest => dest.Properties, opt => opt.Ignore())
				.ForMember(dest => dest.Tag, opt => opt.Ignore());
		}

		private void ConfigureMaps()
		{
			ConfigureHandles();
			ConfigureStructs();
			ConfigureUnions();
		}
	}
}
