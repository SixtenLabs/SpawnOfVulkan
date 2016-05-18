using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct CommandBufferBeginInfo
    {
        internal StructureType sType;
        internal IntPtr pNext;
        internal CommandBufferUsageFlags flags;
        internal CommandBufferInheritanceInfo pInheritanceInfo;
    }
}