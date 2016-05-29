using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct CommandBufferBeginInfo
    {
        internal StructureType SType;
        internal IntPtr PNext;
        internal CommandBufferUsageFlags Flags;
        internal CommandBufferInheritanceInfo PInheritanceInfo;
    }
}