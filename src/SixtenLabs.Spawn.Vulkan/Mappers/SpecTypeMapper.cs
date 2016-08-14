using AutoMapper;
using SixtenLabs.Spawn.Vulkan.Spec;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SixtenLabs.Spawn.Vulkan
{
	public class SpecTypeMapper : Profile
	{
		public SpecTypeMapper()
		{
			ConfigureMaps();
		}

		private void ConfigureMaps()
		{
			CreateMap<VkConstant, SpecTypeDefinition>()
				.ForMember(dest => dest.SpecName, opt => opt.MapFrom(src => src.Name))
				.ForMember(dest => dest.TranslatedName, opt => opt.MapFrom(src => MapTranslatedName(src.Name)));

			CreateMap<VkConstantValue, SpecTypeDefinition>()
				.ForMember(dest => dest.SpecName, opt => opt.MapFrom(src => src.Name))
				.ForMember(dest => dest.TranslatedName, opt => opt.MapFrom(src => MapTranslatedName(src.Name)));

			CreateMap<VkTypeBaseType, SpecTypeDefinition>()
				.ForMember(dest => dest.SpecName, opt => opt.MapFrom(src => src.Name))
				.ForMember(dest => dest.TranslatedName, opt => opt.MapFrom(src => MapTranslatedTypeName(src)));

			CreateMap<VkTypeRequires, SpecTypeDefinition>()
				.ForMember(dest => dest.SpecName, opt => opt.MapFrom(src => src.Name))
				.ForMember(dest => dest.TranslatedName, opt => opt.MapFrom(src => MapTranslatedTypeName(src)));

			CreateMap<VkTypeBitmask, SpecTypeDefinition>()
				.ForMember(dest => dest.SpecName, opt => opt.MapFrom(src => src.Name))
				.ForMember(dest => dest.TranslatedName, opt => opt.MapFrom(src => MapTranslatedName(src.Name)));

			CreateMap<VkCommand, SpecTypeDefinition>()
				.ForMember(dest => dest.SpecName, opt => opt.MapFrom(src => src.Name))
				.ForMember(dest => dest.Children, opt => opt.MapFrom(m => m.Parameters))
				.ForMember(dest => dest.TranslatedName, opt => opt.MapFrom(src => MapTranslatedName(src.Name)));

			CreateMap<VkCommandParameter, SpecTypeDefinition>()
				.ForMember(dest => dest.SpecName, opt => opt.MapFrom(src => src.Name))
				.ForMember(dest => dest.TranslatedName, opt => opt.MapFrom(src => MapTranslatedName(src.Name)));

			CreateMap<VkTypeDefine, SpecTypeDefinition>()
				.ForMember(dest => dest.SpecName, opt => opt.MapFrom(src => src.Name))
				.ForMember(dest => dest.TranslatedName, opt => opt.MapFrom(src => MapTranslatedName(src.Name)));

			CreateMap<VkTypeEnum, SpecTypeDefinition>()
				.ForMember(dest => dest.SpecName, opt => opt.MapFrom(src => src.Name))
				.ForMember(dest => dest.TranslatedName, opt => opt.MapFrom(src => MapTranslatedName(src.Name)));

			CreateMap<VkTypeFuncPointer, SpecTypeDefinition>()
				.ForMember(dest => dest.SpecName, opt => opt.MapFrom(src => src.Name))
				.ForMember(dest => dest.Children, opt => opt.MapFrom(m => m.Parameters))
				.ForMember(dest => dest.TranslatedName, opt => opt.MapFrom(src => MapFuncPointerTranslatedName(src.Name)));

			CreateMap<VkTypeFuncPointerParameter, SpecTypeDefinition>()
				.ForMember(dest => dest.SpecName, opt => opt.MapFrom(src => src.Name))
				.ForMember(dest => dest.TranslatedName, opt => opt.MapFrom(src => MapTranslatedName(src.Name)));

			CreateMap<VkTypeInclude, SpecTypeDefinition>()
				.ForMember(dest => dest.SpecName, opt => opt.MapFrom(src => src.Name))
				.ForMember(dest => dest.TranslatedName, opt => opt.MapFrom(src => MapTranslatedName(src.Name)));

			CreateMap<VkEnumValue, SpecTypeDefinition>()
				.ForMember(dest => dest.SpecName, opt => opt.MapFrom(src => src.Name))
				.ForMember(dest => dest.TranslatedName, opt => opt.MapFrom(src => MapTranslatedName(src.Name)));

			CreateMap<VkTypeStruct, SpecTypeDefinition>()
				.ForMember(dest => dest.SpecName, opt => opt.MapFrom(src => src.Name))
				.ForMember(dest => dest.TranslatedName, opt => opt.MapFrom(src => MapTranslatedName(src.Name)));

			CreateMap<VkTypeStructMember, SpecTypeDefinition>()
				.ForMember(dest => dest.SpecName, opt => opt.MapFrom(src => src.Name))
				.ForMember(dest => dest.TranslatedName, opt => opt.MapFrom(src => MapTranslatedName(src.Name)));

			CreateMap<VkTypeUnion, SpecTypeDefinition>()
				.ForMember(dest => dest.SpecName, opt => opt.MapFrom(src => src.Name))
				.ForMember(dest => dest.TranslatedName, opt => opt.MapFrom(src => MapTranslatedName(src.Name)));

			CreateMap<VkTypeUnionMember, SpecTypeDefinition>()
				.ForMember(dest => dest.SpecName, opt => opt.MapFrom(src => src.Name))
				.ForMember(dest => dest.TranslatedName, opt => opt.MapFrom(src => MapTranslatedName(src.Name)));

			CreateMap<VkTypeHandle, SpecTypeDefinition>()
				.ForMember(dest => dest.SpecName, opt => opt.MapFrom(src => src.Name))
				.ForMember(dest => dest.TranslatedName, opt => opt.MapFrom(src => MapTranslatedName(src.Name)));

			CreateMap<VkExtension, SpecTypeDefinition>()
				.ForMember(dest => dest.SpecName, opt => opt.MapFrom(src => src.Name))
				.ForMember(dest => dest.TranslatedName, opt => opt.MapFrom(src => MapTranslatedName(src.Name)));

			CreateMap<VkExtensionCommand, SpecTypeDefinition>()
				.ForMember(dest => dest.SpecName, opt => opt.MapFrom(src => src.Name))
				.ForMember(dest => dest.TranslatedName, opt => opt.MapFrom(src => MapTranslatedName(src.Name)));

			CreateMap<VkExtensionType, SpecTypeDefinition>()
				.ForMember(dest => dest.SpecName, opt => opt.MapFrom(src => src.Name))
				.ForMember(dest => dest.TranslatedName, opt => opt.MapFrom(src => MapTranslatedName(src.Name)));

			CreateMap<VkExtensionEnum, SpecTypeDefinition>()
				.ForMember(dest => dest.SpecName, opt => opt.MapFrom(src => src.Name))
				.ForMember(dest => dest.TranslatedName, opt => opt.MapFrom(src => MapTranslatedName(src.Name)));
		}

		private string MapTranslatedName(string specName)
		{
			string name = null;

			name = specName.TranslateVulkanName();

			return name;
		}

		private string MapFuncPointerTranslatedName(string specName)
		{
			return "IntPtr";
		}

		private string MapTranslatedTypeName(VkTypeRequires type)
		{
			return CToCSharpTypes[type.Name];
		}

		private string MapTranslatedTypeName(VkTypeBitmask type)
		{
			return CToCSharpTypes[type.Name];
		}

		private string MapTranslatedTypeName(VkTypeBaseType type)
		{
			return CToCSharpTypes[type.Name];
		}

		/// <summary>
		/// Translate the Vulkan types to C# types.
		/// </summary>
		private IDictionary<string, string> CToCSharpTypes { get; } = new Dictionary<string, string>()
		{
			{ "void", "IntPtr" },
			{ "char", "byte" },
			{ "float", "float" },
			{ "uint8_t", "byte" },
			{ "uint32_t", "uint" },
			{ "uint64_t", "ulong" },
			{ "int32_t", "int" },
			{ "size_t", "UIntPtr" },
			{ "VkSampleMask", "uint" },
			{ "VkBool32", "uint" },
			{ "VkFlags", "uint" },
			{ "VkDeviceSize", "ulong" },
			{ "Display", "IntPtr" },
			{ "VisualID", "IntPtr" },
			{ "Window", "IntPtr" },
			{ "ANativeWindow", "IntPtr" },
			{ "MirConnection", "IntPtr" },
			{ "MirSurface", "IntPtr" },
			{ "wl_display", "IntPtr" },
			{ "wl_surface", "IntPtr" },
			{ "HINSTANCE", "IntPtr" },
			{ "HWND", "IntPtr" },
			{ "xcb_connection_t", "IntPtr" },
			{ "xcb_visualid_t", "IntPtr" },
			{ "xcb_window_t", "IntPtr" },
		};
	}
}
