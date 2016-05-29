using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct SwapchainCreateInfoKhr
    {
        internal StructureType SType;
        internal IntPtr PNext;
        internal SwapchainCreateFlagsKhr Flags;
        internal SurfaceKhr Surface;
        internal uint MinImageCount;
        internal Format ImageFormat;
        internal ColorSpaceKhr ImageColorSpace;
        internal Extent2D ImageExtent;
        internal uint ImageArrayLayers;
        internal ImageUsageFlags ImageUsage;
        internal SharingMode ImageSharingMode;
        internal uint QueueFamilyIndexCount;
        internal uint PQueueFamilyIndices;
        internal SurfaceTransformFlagsKhr PreTransform;
        internal CompositeAlphaFlagsKhr CompositeAlpha;
        internal PresentModeKhr PresentMode;
        internal uint Clipped;
        internal SwapchainKhr OldSwapchain;
    }
}