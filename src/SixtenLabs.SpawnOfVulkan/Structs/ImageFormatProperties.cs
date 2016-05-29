using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct ImageFormatProperties
    {
        internal Extent3D MaxExtent;
        internal uint MaxMipLevels;
        internal uint MaxArrayLayers;
        internal SampleCountFlags SampleCounts;
        internal ulong MaxResourceSize;
    }
}