using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct PhysicalDeviceMemoryProperties
    {
        internal uint MemoryTypeCount;
        internal MemoryType MemoryTypes;
        internal uint MemoryHeapCount;
        internal MemoryHeap MemoryHeaps;
    }
}