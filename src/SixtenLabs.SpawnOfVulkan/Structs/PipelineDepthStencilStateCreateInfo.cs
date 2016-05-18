using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct PipelineDepthStencilStateCreateInfo
    {
        internal StructureType sType;
        internal IntPtr pNext;
        internal uint flags;
        internal uint depthTestEnable;
        internal uint depthWriteEnable;
        internal CompareOp depthCompareOp;
        internal uint depthBoundsTestEnable;
        internal uint stencilTestEnable;
        internal StencilOpState front;
        internal StencilOpState back;
        internal float minDepthBounds;
        internal float maxDepthBounds;
    }
}