using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct MemoryBarrier
    {
        internal StructureType sType;
        internal IntPtr pNext;
        internal AccessFlags srcAccessMask;
        internal AccessFlags dstAccessMask;
    }
}