using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct ImageSubresourceLayers
    {
        internal ImageAspectFlags aspectMask;
        internal uint mipLevel;
        internal uint baseArrayLayer;
        internal uint layerCount;
    }
}