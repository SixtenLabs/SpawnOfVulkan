using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct ImageSubresourceRange
    {
        internal ImageAspectFlags aspectMask;
        internal uint baseMipLevel;
        internal uint levelCount;
        internal uint baseArrayLayer;
        internal uint layerCount;
    }
}