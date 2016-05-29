using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct MemoryBarrier
    {
        internal StructureType SType;
        internal IntPtr PNext;
        internal AccessFlags SrcAccessMask;
        internal AccessFlags DstAccessMask;
    }
}