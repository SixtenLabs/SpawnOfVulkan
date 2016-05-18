using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct ImageSubresource
    {
        internal ImageAspectFlags aspectMask;
        internal uint mipLevel;
        internal uint arrayLayer;
    }
}