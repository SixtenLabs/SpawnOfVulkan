using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct PipelineInputAssemblyStateCreateInfo
    {
        internal StructureType sType;
        internal IntPtr pNext;
        internal uint flags;
        internal PrimitiveTopology topology;
        internal uint primitiveRestartEnable;
    }
}