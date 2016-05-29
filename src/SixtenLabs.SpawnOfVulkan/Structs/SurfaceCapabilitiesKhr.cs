using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct SurfaceCapabilitiesKhr
    {
        internal uint MinImageCount;
        internal uint MaxImageCount;
        internal Extent2D CurrentExtent;
        internal Extent2D MinImageExtent;
        internal Extent2D MaxImageExtent;
        internal uint MaxImageArrayLayers;
        internal SurfaceTransformFlagsKhr SupportedTransforms;
        internal SurfaceTransformFlagsKhr CurrentTransform;
        internal CompositeAlphaFlagsKhr SupportedCompositeAlpha;
        internal ImageUsageFlags SupportedUsageFlags;
    }
}