using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct ImageSubresourceLayers
    {
        internal ImageAspectFlags AspectMask;
        internal uint MipLevel;
        internal uint BaseArrayLayer;
        internal uint LayerCount;
    }
}