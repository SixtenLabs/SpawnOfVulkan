using System;

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
        public const int ExtDebugReportSpecVersion = 2;
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
        public const int AmdExtension1SpecVersion = 0;
        public const string AmdExtension1ExtensionName = "VK_AMD_extension_1";
        public const int AmdExtension2SpecVersion = 0;
        public const string AmdExtension2ExtensionName = "VK_AMD_extension_2";
        public const int AmdRasterizationOrderSpecVersion = 1;
        public const string AmdRasterizationOrderExtensionName = "VK_AMD_rasterization_order";
        public const int AmdExtension4SpecVersion = 0;
        public const string AmdExtension4ExtensionName = "VK_AMD_extension_4";
        public const int AmdExtension5SpecVersion = 0;
        public const string AmdExtension5ExtensionName = "VK_AMD_extension_5";
        public const int AmdExtension6SpecVersion = 0;
        public const string AmdExtension6ExtensionName = "VK_AMD_extension_6";
        public const int ExtDebugMarkerSpecVersion = 3;
        public const string ExtDebugMarkerExtensionName = "VK_EXT_debug_marker";
        public const int AmdExtension7SpecVersion = 0;
        public const string AmdExtension7ExtensionName = "VK_AMD_extension_7";
        public const int AmdExtension8SpecVersion = 0;
        public const string AmdExtension8ExtensionName = "VK_AMD_extension_8";
        public const int AmdExtension9SpecVersion = 0;
        public const string AmdExtension9ExtensionName = "VK_AMD_extension_9";
    }
}