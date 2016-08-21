using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct DescriptorImageInfo
    {
        internal SamplerHandle Sampler;
        internal ImageViewHandle ImageView;
        internal ImageLayout ImageLayout;
    }
}