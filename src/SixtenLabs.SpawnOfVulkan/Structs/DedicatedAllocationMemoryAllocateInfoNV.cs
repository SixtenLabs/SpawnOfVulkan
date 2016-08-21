using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct DedicatedAllocationMemoryAllocateInfoNV
    {
        internal StructureType SType;
        internal IntPtr PNext;
        internal ImageHandle Image;
        internal BufferHandle Buffer;
    }
}