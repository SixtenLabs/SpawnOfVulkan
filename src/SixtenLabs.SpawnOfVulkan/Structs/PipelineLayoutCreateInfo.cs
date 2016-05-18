using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct PipelineLayoutCreateInfo
    {
        internal StructureType sType;
        internal IntPtr pNext;
        internal uint flags;
        internal uint setLayoutCount;
        internal DescriptorSetLayout pSetLayouts;
        internal uint pushConstantRangeCount;
        internal PushConstantRange pPushConstantRanges;
    }
}