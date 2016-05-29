using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct PipelineLayoutCreateInfo
    {
        internal StructureType SType;
        internal IntPtr PNext;
        internal PipelineLayoutCreateFlags Flags;
        internal uint SetLayoutCount;
        internal DescriptorSetLayout PSetLayouts;
        internal uint PushConstantRangeCount;
        internal PushConstantRange PPushConstantRanges;
    }
}