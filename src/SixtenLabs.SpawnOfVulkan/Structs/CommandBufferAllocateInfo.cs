using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct CommandBufferAllocateInfo
    {
        internal StructureType SType;
        internal IntPtr PNext;
        internal CommandPool CommandPool;
        internal CommandBufferLevel Level;
        internal uint CommandBufferCount;
    }
}