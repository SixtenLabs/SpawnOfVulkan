using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct PipelineMultisampleStateCreateInfo
    {
        internal StructureType sType;
        internal IntPtr pNext;
        internal uint flags;
        internal SampleCountFlags rasterizationSamples;
        internal uint sampleShadingEnable;
        internal float minSampleShading;
        internal uint pSampleMask;
        internal uint alphaToCoverageEnable;
        internal uint alphaToOneEnable;
    }
}