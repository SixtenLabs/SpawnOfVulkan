using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct DescriptorSetLayoutBinding
    {
        internal uint Binding;
        internal DescriptorType DescriptorType;
        internal uint DescriptorCount;
        internal ShaderStageFlags StageFlags;
        internal SamplerHandle PImmutableSamplers;
    }
}