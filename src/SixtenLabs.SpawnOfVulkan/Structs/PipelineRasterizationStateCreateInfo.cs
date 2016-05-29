using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct PipelineRasterizationStateCreateInfo
    {
        internal StructureType SType;
        internal IntPtr PNext;
        internal PipelineRasterizationStateCreateFlags Flags;
        internal uint DepthClampEnable;
        internal uint RasterizerDiscardEnable;
        internal PolygonMode PolygonMode;
        internal CullModeFlags CullMode;
        internal FrontFace FrontFace;
        internal uint DepthBiasEnable;
        internal float DepthBiasConstantFactor;
        internal float DepthBiasClamp;
        internal float DepthBiasSlopeFactor;
        internal float LineWidth;
    }
}