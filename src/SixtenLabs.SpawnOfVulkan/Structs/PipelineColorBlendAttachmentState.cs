using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct PipelineColorBlendAttachmentState
    {
        internal uint blendEnable;
        internal BlendFactor srcColorBlendFactor;
        internal BlendFactor dstColorBlendFactor;
        internal BlendOp colorBlendOp;
        internal BlendFactor srcAlphaBlendFactor;
        internal BlendFactor dstAlphaBlendFactor;
        internal BlendOp alphaBlendOp;
        internal ColorComponentFlags colorWriteMask;
    }
}