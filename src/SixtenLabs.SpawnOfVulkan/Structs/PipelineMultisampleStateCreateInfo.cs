using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct PipelineMultisampleStateCreateInfo
    {
        internal StructureType SType;
        internal IntPtr PNext;
        internal PipelineMultisampleStateCreateFlags Flags;
        internal SampleCountFlags RasterizationSamples;
        internal uint SampleShadingEnable;
        internal float MinSampleShading;
        internal uint PSampleMask;
        internal uint AlphaToCoverageEnable;
        internal uint AlphaToOneEnable;
    }
}