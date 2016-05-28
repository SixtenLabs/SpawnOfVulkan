using AutoMapper;
using SixtenLabs.Spawn.Vulkan.Spec;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SixtenLabs.Spawn.Vulkan
{
	public class SpecTypeMapper : Profile
	{
		protected override void Configure()
		{
			CreateMap<VkTypeBaseType, SpecTypeDefinition>()
				.ForMember(dest => dest.SpecName, opt => opt.MapFrom(src => src.Name))
				.ForMember(dest => dest.TranslatedName, opt => opt.MapFrom(src => MapTranslatedName(src.Name)));

			CreateMap<VkTypeRequires, SpecTypeDefinition>()
				.ForMember(dest => dest.SpecName, opt => opt.MapFrom(src => src.Name))
				.ForMember(dest => dest.TranslatedName, opt => opt.MapFrom(src => MapTranslatedName(src.Name)));

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
				.ForMember(dest => dest.TranslatedName, opt => opt.MapFrom(src => MapTranslatedName(src.Name)));

			CreateMap<VkTypeFuncPointerParameter, SpecTypeDefinition>()
				.ForMember(dest => dest.SpecName, opt => opt.MapFrom(src => src.Name))
				.ForMember(dest => dest.TranslatedName, opt => opt.MapFrom(src => MapTranslatedName(src.Name)));

			CreateMap<VkTypeInclude, SpecTypeDefinition>()
				.ForMember(dest => dest.SpecName, opt => opt.MapFrom(src => src.Name))
				.ForMember(dest => dest.TranslatedName, opt => opt.MapFrom(src => MapTranslatedName(src.Name)));

			CreateMap<VkTypeUnion, SpecTypeDefinition>()
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

			CreateMap<VkTypeHandle, SpecTypeDefinition>()
				.ForMember(dest => dest.SpecName, opt => opt.MapFrom(src => src.Name))
				.ForMember(dest => dest.TranslatedName, opt => opt.MapFrom(src => MapTranslatedName(src.Name)));
		}

		private string MapTranslatedName(string specName)
		{
			string name = null;

			name = specName.TranslateVulkanName();

			return name;
		}

		//private string MapTranslatedName(registryType rt)
		//{
		//	string name = null;

		//	if (Requires.Contains(rt.requires))
		//	{
		//		name = CToCSharpTypes[rt.name];
		//	}
		//	else if (rt.category == "basetype")
		//	{
		//		name = CToCSharpTypes[rt.Items[0] as string];
		//	}
		//	else if (rt.category == "bitmask" && !string.IsNullOrEmpty(rt.requires))
		//	{
		//		// Real Enum
		//		name = (rt.Items[1] as string).TranslateVulkanName();
		//	}
		//	else if (rt.category == "bitmask" && string.IsNullOrEmpty(rt.requires))
		//	{
		//		// Not real enum.
		//		name = CToCSharpTypes[rt.Items[0] as string];
		//	}
		//	else if (rt.category == "handle")
		//	{
		//		name = (rt.Items[1] as string).TranslateVulkanName();
		//	}
		//	else if (rt.category == "funcpointer")
		//	{
		//		//name = (rt.Items[0] as string).TranslateVulkanName();
		//		name = "IntPtr";
		//	}
		//	else if (rt.category == "enum" || rt.category == "struct" || rt.category == "union")
		//	{
		//		name = rt.name.TranslateVulkanName();
		//	}
		//	else if (rt.category == "include" || rt.category == "define")
		//	{
		//		name = string.IsNullOrEmpty(rt.name) ? rt.Items[0] as string : rt.name;
		//	}
		//	else
		//	{
		//		name = "";
		//	}

		//	return name;
		//}

		private IList<string> Requires { get; } = new List<string>()
		{
			"X11/Xlib.h",
			"android/native_window.h",
			"mir_toolkit/client_types.h",
			"wayland-client.h",
			"windows.h",
			"xcb/xcb.h",
			"vk_platform"
		};

		/// <summary>
		/// Translate the Vulkan types to C# types.
		/// </summary>
		private IDictionary<string, string> CToCSharpTypes { get; } = new Dictionary<string, string>()
		{
			{ "void", "IntPtr" },
			{ "char", "string" }, // Should this be string?
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
