using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct CommandBufferAllocateInfo
    {
        internal StructureType SType;
        internal IntPtr PNext;
        internal CommandPoolHandle CommandPool;
        internal CommandBufferLevel Level;
        internal uint CommandBufferCount;
    }
}