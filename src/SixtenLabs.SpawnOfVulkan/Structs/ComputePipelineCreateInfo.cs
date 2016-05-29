using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct ComputePipelineCreateInfo
    {
        internal StructureType SType;
        internal IntPtr PNext;
        internal PipelineCreateFlags Flags;
        internal PipelineShaderStageCreateInfo Stage;
        internal PipelineLayout Layout;
        internal Pipeline BasePipelineHandle;
        internal int BasePipelineIndex;
    }
}