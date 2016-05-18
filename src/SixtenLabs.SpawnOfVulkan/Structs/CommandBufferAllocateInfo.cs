using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct CommandBufferAllocateInfo
    {
        internal StructureType sType;
        internal IntPtr pNext;
        internal CommandPool commandPool;
        internal CommandBufferLevel level;
        internal uint commandBufferCount;
    }
}