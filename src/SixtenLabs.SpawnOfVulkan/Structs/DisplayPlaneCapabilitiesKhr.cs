using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct DisplayPlaneCapabilitiesKhr
    {
        internal DisplayPlaneAlphaFlagsKhr supportedAlpha;
        internal Offset2D minSrcPosition;
        internal Offset2D maxSrcPosition;
        internal Extent2D minSrcExtent;
        internal Extent2D maxSrcExtent;
        internal Offset2D minDstPosition;
        internal Offset2D maxDstPosition;
        internal Extent2D minDstExtent;
        internal Extent2D maxDstExtent;
    }
}