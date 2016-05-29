using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct PipelineDepthStencilStateCreateInfo
    {
        internal StructureType SType;
        internal IntPtr PNext;
        internal PipelineDepthStencilStateCreateFlags Flags;
        internal uint DepthTestEnable;
        internal uint DepthWriteEnable;
        internal CompareOp DepthCompareOp;
        internal uint DepthBoundsTestEnable;
        internal uint StencilTestEnable;
        internal StencilOpState Front;
        internal StencilOpState Back;
        internal float MinDepthBounds;
        internal float MaxDepthBounds;
    }
}