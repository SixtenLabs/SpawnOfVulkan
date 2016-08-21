using AutoMapper;
using SixtenLabs.Spawn.CSharp;
using SixtenLabs.Spawn.Vulkan.Spec;

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
				.ForMember(dest => dest.Name, opt => opt.MapFrom(m => new DefinitionName() { OriginalName = m.Name }))
				.ForMember(dest => dest.Fields, opt => opt.MapFrom(m => m.Members))
				.ForMember(dest => dest.SpecDerivedType, opt => opt.Ignore())
				.ForMember(dest => dest.DerivedType, opt => opt.Ignore())
				.ForMember(dest => dest.NeedsMarshalling, opt => opt.Ignore())
				.ForMember(dest => dest.Attributes, opt => opt.Ignore())
				.ForMember(dest => dest.Comments, opt => opt.Ignore())
				.ForMember(dest => dest.ModifierDefinitions, opt => opt.Ignore())
				.ForMember(dest => dest.Constructors, opt => opt.Ignore())
        .ForMember(dest => dest.Properties, opt => opt.Ignore())
        .ForMember(dest => dest.Tag, opt => opt.Ignore());

      CreateMap<VkTypeStructMember, FieldDefinition>()
        .ForMember(dest => dest.Name, opt => opt.MapFrom(m => new DefinitionName() { OriginalName = m.Name }))
        .ForMember(dest => dest.ReturnType, opt => opt.MapFrom(m => new DefinitionName() { OriginalName = m.ReturnType }))
        .ForMember(dest => dest.ReturnTypeIsArray, opt => opt.MapFrom(m => m.IsArray))
        .ForMember(dest => dest.Tag, opt => opt.MapFrom(m => m.ArrayCount))
        .ForMember(dest => dest.DefaultValue, opt => opt.Ignore())
        .ForMember(dest => dest.AttributeDefinitions, opt => opt.Ignore())
        .ForMember(dest => dest.ModifierDefinitions, opt => opt.Ignore())
        .ForMember(dest => dest.ArraySize, opt => opt.Ignore());
			}

		private void ConfigureUnions()
		{
			CreateMap<VkTypeUnion, StructDefinition>()
				.ForMember(dest => dest.Name, opt => opt.MapFrom(m => new DefinitionName() { OriginalName = m.Name }))
				.ForMember(dest => dest.Fields, opt => opt.MapFrom(m => m.Members))
				.ForMember(dest => dest.SpecDerivedType, opt => opt.Ignore())
				.ForMember(dest => dest.DerivedType, opt => opt.Ignore())
				.ForMember(dest => dest.NeedsMarshalling, opt => opt.Ignore())
				.ForMember(dest => dest.Attributes, opt => opt.Ignore())
				.ForMember(dest => dest.Comments, opt => opt.Ignore())
				.ForMember(dest => dest.ModifierDefinitions, opt => opt.Ignore())
				.ForMember(dest => dest.Constructors, opt => opt.Ignore())
        .ForMember(dest => dest.Properties, opt => opt.Ignore())
        .ForMember(dest => dest.Tag, opt => opt.Ignore());

			CreateMap<VkTypeUnionMember, FieldDefinition>()
				.ForMember(dest => dest.Name, opt => opt.MapFrom(m => new DefinitionName() { OriginalName = m.Name }))
				.ForMember(dest => dest.ReturnType, opt => opt.MapFrom(m => new DefinitionName() { OriginalName = m.ReturnType }))
				.ForMember(dest => dest.ReturnTypeIsArray, opt => opt.MapFrom(m => m.IsArray))
				.ForMember(dest => dest.Tag, opt => opt.MapFrom(m => m.ArrayCount))
				.ForMember(dest => dest.DefaultValue, opt => opt.Ignore())
				.ForMember(dest => dest.ArraySize, opt => opt.Ignore())
        .ForMember(dest => dest.AttributeDefinitions, opt => opt.Ignore())
        .ForMember(dest => dest.ModifierDefinitions, opt => opt.Ignore());
		}

		private void ConfigureHandles()
		{
			CreateMap<VkTypeHandle, StructDefinition>()
				.ForMember(dest => dest.Name, opt => opt.MapFrom(m => new DefinitionName() { OriginalName = m.Name }))
				.ForMember(dest => dest.SpecDerivedType, opt => opt.MapFrom(m => m.Parent))
				.ForMember(dest => dest.DerivedType, opt => opt.Ignore())
				.ForMember(dest => dest.Attributes, opt => opt.Ignore())
				.ForMember(dest => dest.Comments, opt => opt.Ignore())
				.ForMember(dest => dest.ModifierDefinitions, opt => opt.Ignore())
				.ForMember(dest => dest.NeedsMarshalling, opt => opt.Ignore())
				.ForMember(dest => dest.Fields, opt => opt.Ignore())
        .ForMember(dest => dest.Constructors, opt => opt.Ignore())
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
