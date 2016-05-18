using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct BufferCreateInfo
    {
        internal StructureType sType;
        internal IntPtr pNext;
        internal BufferCreateFlags flags;
        internal ulong size;
        internal BufferUsageFlags usage;
        internal SharingMode sharingMode;
        internal uint queueFamilyIndexCount;
        internal uint pQueueFamilyIndices;
    }
}