using System;

namespace SixtenLabs.SpawnOfVulkan
{
    unsafe public struct PhysicalDeviceMemoryProperties
    {
        internal uint memoryTypeCount;
        internal MemoryType memoryTypes;
        internal uint memoryHeapCount;
        internal MemoryHeap memoryHeaps;
    }
}