using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct ImageCreateInfo
    {
        internal StructureType sType;
        internal IntPtr pNext;
        internal ImageCreateFlags flags;
        internal ImageType imageType;
        internal Format format;
        internal Extent3D extent;
        internal uint mipLevels;
        internal uint arrayLayers;
        internal SampleCountFlags samples;
        internal ImageTiling tiling;
        internal ImageUsageFlags usage;
        internal SharingMode sharingMode;
        internal uint queueFamilyIndexCount;
        internal uint pQueueFamilyIndices;
        internal ImageLayout initialLayout;
    }
}