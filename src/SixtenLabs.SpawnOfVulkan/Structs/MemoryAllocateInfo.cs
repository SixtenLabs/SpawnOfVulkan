using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct MemoryAllocateInfo
    {
        internal StructureType SType;
        internal IntPtr PNext;
        internal ulong AllocationSize;
        internal uint MemoryTypeIndex;
    }
}