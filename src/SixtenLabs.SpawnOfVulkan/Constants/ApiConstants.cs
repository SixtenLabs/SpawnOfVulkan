﻿using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public static class ApiConstants
    {
        public const uint MaxPhysicalDeviceNameSize = 256;
        public const uint UuidSize = 16;
        public const uint MaxExtensionNameSize = 256;
        public const uint MaxDescriptionSize = 256;
        public const uint MaxMemoryTypes = 32;
        public const uint MaxMemoryHeaps = 16;
        public const float LodClampNone = 1000F;
        public const uint RemainingMipLevels = uint.MaxValue;
        public const uint RemainingArrayLayers = uint.MaxValue;
        public const ulong WholeSize = ulong.MaxValue;
        public const uint AttachmentUnused = uint.MaxValue;
        public const uint TRUE = 1;
        public const uint FALSE = 0;
        public const uint QueueFamilyIgnored = uint.MaxValue;
        public const uint SubpassExternal = uint.MaxValue;
        public const int KhrSurfaceSpecVersion = 25;
        public const string KhrSurfaceExtensionName = "VK_KHR_surface";
        public const string ColorspaceSrgbNonlinearKhr = "VK_COLOR_SPACE_SRGB_NONLINEAR_KHR";
        public const int KhrSwapchainSpecVersion = 68;
        public const string KhrSwapchainExtensionName = "VK_KHR_swapchain";
        public const int KhrDisplaySpecVersion = 21;
        public const string KhrDisplayExtensionName = "VK_KHR_display";
        public const int KhrDisplaySwapchainSpecVersion = 9;
        public const string KhrDisplaySwapchainExtensionName = "VK_KHR_display_swapchain";
        public const int KhrXlibSurfaceSpecVersion = 6;
        public const string KhrXlibSurfaceExtensionName = "VK_KHR_xlib_surface";
        public const int KhrXcbSurfaceSpecVersion = 6;
        public const string KhrXcbSurfaceExtensionName = "VK_KHR_xcb_surface";
        public const int KhrWaylandSurfaceSpecVersion = 5;
        public const string KhrWaylandSurfaceExtensionName = "VK_KHR_wayland_surface";
        public const int KhrMirSurfaceSpecVersion = 4;
        public const string KhrMirSurfaceExtensionName = "VK_KHR_mir_surface";
        public const int KhrAndroidSurfaceSpecVersion = 6;
        public const string KhrAndroidSurfaceExtensionName = "VK_KHR_android_surface";
        public const int KhrWin32SurfaceSpecVersion = 5;
        public const string KhrWin32SurfaceExtensionName = "VK_KHR_win32_surface";
        public const int AndroidNativeBufferSpecVersion = 4;
        public const int AndroidNativeBufferNumber = 11;
        public const string AndroidNativeBufferName = "VK_ANDROID_native_buffer";
        public const int ExtDebugReportSpecVersion = 3;
        public const string ExtDebugReportExtensionName = "VK_EXT_debug_report";
        public const string StructureTypeDebugReportCreateInfoExt = "VK_STRUCTURE_TYPE_DEBUG_REPORT_CALLBACK_CREATE_INFO_EXT";
        public const int NvGlslShaderSpecVersion = 1;
        public const string NvGlslShaderExtensionName = "VK_NV_glsl_shader";
        public const int NvExtension1SpecVersion = 0;
        public const string NvExtension1ExtensionName = "VK_NV_extension_1";
        public const int KhrSamplerMirrorClampToEdgeSpecVersion = 1;
        public const string KhrSamplerMirrorClampToEdgeExtensionName = "VK_KHR_sampler_mirror_clamp_to_edge";
        public const int ImgFilterCubicSpecVersion = 1;
        public const string ImgFilterCubicExtensionName = "VK_IMG_filter_cubic";
        public const int AmdExtension17SpecVersion = 0;
        public const string AmdExtension17ExtensionName = "VK_AMD_extension_17";
        public const int AmdExtension18SpecVersion = 0;
        public const string AmdExtension18ExtensionName = "VK_AMD_extension_18";
        public const int AmdRasterizationOrderSpecVersion = 1;
        public const string AmdRasterizationOrderExtensionName = "VK_AMD_rasterization_order";
        public const int AmdExtension20SpecVersion = 0;
        public const string AmdExtension20ExtensionName = "VK_AMD_extension_20";
        public const int AmdShaderTrinaryMinmaxSpecVersion = 1;
        public const string AmdShaderTrinaryMinmaxExtensionName = "VK_AMD_shader_trinary_minmax";
        public const int AmdShaderExplicitVertexParameterSpecVersion = 1;
        public const string AmdShaderExplicitVertexParameterExtensionName = "VK_AMD_shader_explicit_vertex_parameter";
        public const int ExtDebugMarkerSpecVersion = 3;
        public const string ExtDebugMarkerExtensionName = "VK_EXT_debug_marker";
        public const int AmdExtension24SpecVersion = 0;
        public const string AmdExtension24ExtensionName = "VK_AMD_extension_24";
        public const int AmdExtension25SpecVersion = 0;
        public const string AmdExtension25ExtensionName = "VK_AMD_extension_25";
        public const int AmdGcnShaderSpecVersion = 1;
        public const string AmdGcnShaderExtensionName = "VK_AMD_gcn_shader";
        public const int NvDedicatedAllocationSpecVersion = 1;
        public const string NvDedicatedAllocationExtensionName = "VK_NV_dedicated_allocation";
        public const int ExtExtension28SpecVersion = 0;
        public const string ExtExtension28ExtensionName = "VK_NV_extension_28";
        public const int NvxExtension29SpecVersion = 0;
        public const string NvxExtension29ExtensionName = "VK_NVX_extension_29";
        public const int NvxExtension30SpecVersion = 0;
        public const string NvxExtension30ExtensionName = "VK_NVX_extension_30";
        public const int NvxExtension31SpecVersion = 0;
        public const string NvxExtension31ExtensionName = "VK_NVX_extension_31";
        public const int AmdExtension32SpecVersion = 0;
        public const string AmdExtension32ExtensionName = "VK_AMD_extension_32";
        public const int AmdExtension33SpecVersion = 0;
        public const string AmdExtension33ExtensionName = "VK_AMD_extension_33";
        public const int AmdExtension34SpecVersion = 0;
        public const string AmdExtension34ExtensionName = "VK_AMD_extension_34";
        public const int AmdExtension35SpecVersion = 0;
        public const string AmdExtension35ExtensionName = "VK_AMD_extension_35";
        public const int AmdExtension36SpecVersion = 0;
        public const string AmdExtension36ExtensionName = "VK_AMD_extension_36";
        public const int AmdExtension37SpecVersion = 0;
        public const string AmdExtension37ExtensionName = "VK_AMD_extension_37";
        public const int AmdExtension38SpecVersion = 0;
        public const string AmdExtension38ExtensionName = "VK_AMD_extension_38";
        public const int AmdExtension39SpecVersion = 0;
        public const string AmdExtension39ExtensionName = "VK_AMD_extension_39";
        public const int AmdExtension40SpecVersion = 0;
        public const string AmdExtension40ExtensionName = "VK_AMD_extension_40";
        public const int AmdExtension41SpecVersion = 0;
        public const string AmdExtension41ExtensionName = "VK_AMD_extension_41";
        public const int AmdExtension42SpecVersion = 0;
        public const string AmdExtension42ExtensionName = "VK_AMD_extension_42";
        public const int AmdExtension43SpecVersion = 0;
        public const string AmdExtension43ExtensionName = "VK_AMD_extension_43";
        public const int AmdExtension44SpecVersion = 0;
        public const string AmdExtension44ExtensionName = "VK_AMD_extension_44";
        public const int AmdExtension45SpecVersion = 0;
        public const string AmdExtension45ExtensionName = "VK_AMD_extension_45";
        public const int AmdExtension46SpecVersion = 0;
        public const string AmdExtension46ExtensionName = "VK_AMD_extension_46";
        public const int AmdExtension47SpecVersion = 0;
        public const string AmdExtension47ExtensionName = "VK_AMD_extension_47";
        public const int NvxExtension48SpecVersion = 0;
        public const string NvxExtension48ExtensionName = "VK_NVX_extension_48";
        public const int GoogleExtension49SpecVersion = 0;
        public const string GoogleExtension49ExtensionName = "VK_GOOGLE_extension_49";
        public const int GoogleExtension50SpecVersion = 0;
        public const string GoogleExtension50ExtensionName = "VK_GOOGLE_extension_50";
        public const int NvxExtension51SpecVersion = 0;
        public const string NvxExtension51ExtensionName = "VK_NVX_extension_51";
        public const int NvxExtension52SpecVersion = 0;
        public const string NvxExtension52ExtensionName = "VK_NVX_extension_52";
        public const int NvExtension53SpecVersion = 0;
        public const string NvExtension53ExtensionName = "VK_NV_extension_53";
        public const int NvExtension54SpecVersion = 0;
        public const string NvExtension54ExtensionName = "VK_NV_extension_54";
        public const int ImgFormatPvrtcSpecVersion = 1;
        public const string ImgFormatPvrtcExtensionName = "VK_IMG_format_pvrtc";
    }
}