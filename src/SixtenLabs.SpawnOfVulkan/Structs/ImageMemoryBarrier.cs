using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct ImageMemoryBarrier
    {
        internal StructureType SType;
        internal IntPtr PNext;
        internal AccessFlags SrcAccessMask;
        internal AccessFlags DstAccessMask;
        internal ImageLayout OldLayout;
        internal ImageLayout NewLayout;
        internal uint SrcQueueFamilyIndex;
        internal uint DstQueueFamilyIndex;
        internal ImageHandle Image;
        internal ImageSubresourceRange SubresourceRange;
    }
}