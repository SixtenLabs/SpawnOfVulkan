using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct DescriptorImageInfo
    {
        internal Sampler Sampler;
        internal ImageView ImageView;
        internal ImageLayout ImageLayout;
    }
}