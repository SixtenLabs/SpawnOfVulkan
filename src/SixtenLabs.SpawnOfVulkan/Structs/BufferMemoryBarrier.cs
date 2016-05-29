using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct BufferMemoryBarrier
    {
        internal StructureType SType;
        internal IntPtr PNext;
        internal AccessFlags SrcAccessMask;
        internal AccessFlags DstAccessMask;
        internal uint SrcQueueFamilyIndex;
        internal uint DstQueueFamilyIndex;
        internal Buffer Buffer;
        internal ulong Offset;
        internal ulong Size;
    }
}