using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct SurfaceCapabilitiesKhr
    {
        internal uint minImageCount;
        internal uint maxImageCount;
        internal Extent2D currentExtent;
        internal Extent2D minImageExtent;
        internal Extent2D maxImageExtent;
        internal uint maxImageArrayLayers;
        internal SurfaceTransformFlagsKhr supportedTransforms;
        internal SurfaceTransformFlagsKhr currentTransform;
        internal CompositeAlphaFlagsKhr supportedCompositeAlpha;
        internal ImageUsageFlags supportedUsageFlags;
    }
}