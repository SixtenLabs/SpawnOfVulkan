using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct DisplayPlaneCapabilitiesKhr
    {
        internal DisplayPlaneAlphaFlagsKhr SupportedAlpha;
        internal Offset2D MinSrcPosition;
        internal Offset2D MaxSrcPosition;
        internal Extent2D MinSrcExtent;
        internal Extent2D MaxSrcExtent;
        internal Offset2D MinDstPosition;
        internal Offset2D MaxDstPosition;
        internal Extent2D MinDstExtent;
        internal Extent2D MaxDstExtent;
    }
}