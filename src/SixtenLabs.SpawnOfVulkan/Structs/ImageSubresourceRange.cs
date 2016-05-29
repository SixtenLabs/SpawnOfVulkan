using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct ImageSubresourceRange
    {
        internal ImageAspectFlags AspectMask;
        internal uint BaseMipLevel;
        internal uint LevelCount;
        internal uint BaseArrayLayer;
        internal uint LayerCount;
    }
}