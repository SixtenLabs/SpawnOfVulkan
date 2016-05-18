using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct ImageViewCreateInfo
    {
        internal StructureType sType;
        internal IntPtr pNext;
        internal uint flags;
        internal Image image;
        internal ImageViewType viewType;
        internal Format format;
        internal ComponentMapping components;
        internal ImageSubresourceRange subresourceRange;
    }
}