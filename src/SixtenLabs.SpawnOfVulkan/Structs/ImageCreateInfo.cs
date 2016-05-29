using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct ImageCreateInfo
    {
        internal StructureType SType;
        internal IntPtr PNext;
        internal ImageCreateFlags Flags;
        internal ImageType ImageType;
        internal Format Format;
        internal Extent3D Extent;
        internal uint MipLevels;
        internal uint ArrayLayers;
        internal SampleCountFlags Samples;
        internal ImageTiling Tiling;
        internal ImageUsageFlags Usage;
        internal SharingMode SharingMode;
        internal uint QueueFamilyIndexCount;
        internal uint PQueueFamilyIndices;
        internal ImageLayout InitialLayout;
    }
}