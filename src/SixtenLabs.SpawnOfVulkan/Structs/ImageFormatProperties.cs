using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct ImageFormatProperties
    {
        internal Extent3D maxExtent;
        internal uint maxMipLevels;
        internal uint maxArrayLayers;
        internal SampleCountFlags sampleCounts;
        internal ulong maxResourceSize;
    }
}