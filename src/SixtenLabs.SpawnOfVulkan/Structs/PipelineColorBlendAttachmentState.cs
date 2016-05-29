using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct PipelineColorBlendAttachmentState
    {
        internal uint BlendEnable;
        internal BlendFactor SrcColorBlendFactor;
        internal BlendFactor DstColorBlendFactor;
        internal BlendOp ColorBlendOp;
        internal BlendFactor SrcAlphaBlendFactor;
        internal BlendFactor DstAlphaBlendFactor;
        internal BlendOp AlphaBlendOp;
        internal ColorComponentFlags ColorWriteMask;
    }
}