﻿using AutoMapper;
using SixtenLabs.Spawn.CSharp;
using SixtenLabs.Spawn.Vulkan.Spec;
using System.Linq;

namespace SixtenLabs.Spawn.Vulkan
{
	public class RegistryTypeMapper : Profile
	{
		protected override void Configure()
		{
			CreateMap<VkTypeHandle, StructDefinition>()
				.ForMember(dest => dest.SpecName, opt => opt.MapFrom(m => m.Name))
				.ForMember(dest => dest.SpecDerivedType, opt => opt.MapFrom(m => m.Parent));

			CreateMap<VkTypeStruct, StructDefinition>()
				.ForMember(dest => dest.SpecName, opt => opt.MapFrom(m => m.Name))
				//.ForMember(dest => dest.SpecDerivedType, opt => opt.MapFrom(m => m.Pa.parent))
				//.ForMember(dest => dest.Comments, opt => opt.MapFrom(m => MapComments(m.comment)))
				//.ForMember(dest => dest.NeedsMarshalling, opt => opt.MapFrom(m => MapNeedsMarshalling(m)))
				.ForMember(dest => dest.Fields, opt => opt.MapFrom(m => m.Members));
	
			CreateMap<VkTypeStructMember, FieldDefinition>()
				.ForMember(dest => dest.SpecName, opt => opt.MapFrom(m => m.Name))
				.ForMember(dest => dest.SpecReturnType, opt => opt.MapFrom(m => m.ReturnType))
				.ForMember(dest => dest.ReturnTypeIsArray, opt => opt.MapFrom(m => m.IsArray))
				.ForMember(dest => dest.Tag, opt => opt.MapFrom(m => m.ArrayCount))
				.ForMember(dest => dest.SpecType, opt => opt.MapFrom(m => m.ReturnType));
		}
	}
}
