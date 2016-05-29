using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct BufferCreateInfo
    {
        internal StructureType SType;
        internal IntPtr PNext;
        internal BufferCreateFlags Flags;
        internal ulong Size;
        internal BufferUsageFlags Usage;
        internal SharingMode SharingMode;
        internal uint QueueFamilyIndexCount;
        internal uint PQueueFamilyIndices;
    }
}