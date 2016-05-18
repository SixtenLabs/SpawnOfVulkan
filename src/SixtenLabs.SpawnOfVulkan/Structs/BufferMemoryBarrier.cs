using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct BufferMemoryBarrier
    {
        internal StructureType sType;
        internal IntPtr pNext;
        internal AccessFlags srcAccessMask;
        internal AccessFlags dstAccessMask;
        internal uint srcQueueFamilyIndex;
        internal uint dstQueueFamilyIndex;
        internal Buffer buffer;
        internal ulong offset;
        internal ulong size;
    }
}