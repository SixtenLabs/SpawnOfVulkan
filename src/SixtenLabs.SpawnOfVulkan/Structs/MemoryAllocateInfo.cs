using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct MemoryAllocateInfo
    {
        internal StructureType sType;
        internal IntPtr pNext;
        internal ulong allocationSize;
        internal uint memoryTypeIndex;
    }
}