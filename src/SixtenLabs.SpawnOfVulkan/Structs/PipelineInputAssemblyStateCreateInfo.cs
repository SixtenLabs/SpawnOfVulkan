using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct PipelineInputAssemblyStateCreateInfo
    {
        internal StructureType SType;
        internal IntPtr PNext;
        internal PipelineInputAssemblyStateCreateFlags Flags;
        internal PrimitiveTopology Topology;
        internal uint PrimitiveRestartEnable;
    }
}