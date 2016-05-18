using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct DescriptorSetLayoutBinding
    {
        internal uint binding;
        internal DescriptorType descriptorType;
        internal uint descriptorCount;
        internal ShaderStageFlags stageFlags;
        internal Sampler pImmutableSamplers;
    }
}