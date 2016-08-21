using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct PipelineLayoutCreateInfo
    {
        internal StructureType SType;
        internal IntPtr PNext;
        internal PipelineLayoutCreateFlags Flags;
        internal uint SetLayoutCount;
        internal DescriptorSetLayoutHandle PSetLayouts;
        internal uint PushConstantRangeCount;
        internal PushConstantRange PPushConstantRanges;
    }
}