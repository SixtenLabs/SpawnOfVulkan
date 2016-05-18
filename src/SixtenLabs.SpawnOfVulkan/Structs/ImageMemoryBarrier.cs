using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct ImageMemoryBarrier
    {
        internal StructureType sType;
        internal IntPtr pNext;
        internal AccessFlags srcAccessMask;
        internal AccessFlags dstAccessMask;
        internal ImageLayout oldLayout;
        internal ImageLayout newLayout;
        internal uint srcQueueFamilyIndex;
        internal uint dstQueueFamilyIndex;
        internal Image image;
        internal ImageSubresourceRange subresourceRange;
    }
}