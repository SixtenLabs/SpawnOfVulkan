using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct SwapchainCreateInfoKhr
    {
        internal StructureType sType;
        internal IntPtr pNext;
        internal uint flags;
        internal SurfaceKhr surface;
        internal uint minImageCount;
        internal Format imageFormat;
        internal ColorSpaceKhr imageColorSpace;
        internal Extent2D imageExtent;
        internal uint imageArrayLayers;
        internal ImageUsageFlags imageUsage;
        internal SharingMode imageSharingMode;
        internal uint queueFamilyIndexCount;
        internal uint pQueueFamilyIndices;
        internal SurfaceTransformFlagsKhr preTransform;
        internal CompositeAlphaFlagsKhr compositeAlpha;
        internal PresentModeKhr presentMode;
        internal uint clipped;
        internal SwapchainKhr oldSwapchain;
    }
}