using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct ComputePipelineCreateInfo
    {
        internal StructureType sType;
        internal IntPtr pNext;
        internal PipelineCreateFlags flags;
        internal PipelineShaderStageCreateInfo stage;
        internal PipelineLayout layout;
        internal Pipeline basePipelineHandle;
        internal int basePipelineIndex;
    }
}