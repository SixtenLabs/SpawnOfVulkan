using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct DescriptorImageInfo
    {
        internal Sampler sampler;
        internal ImageView imageView;
        internal ImageLayout imageLayout;
    }
}