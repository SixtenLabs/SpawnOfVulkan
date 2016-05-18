using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct PipelineRasterizationStateCreateInfo
    {
        internal StructureType sType;
        internal IntPtr pNext;
        internal uint flags;
        internal uint depthClampEnable;
        internal uint rasterizerDiscardEnable;
        internal PolygonMode polygonMode;
        internal CullModeFlags cullMode;
        internal FrontFace frontFace;
        internal uint depthBiasEnable;
        internal float depthBiasConstantFactor;
        internal float depthBiasClamp;
        internal float depthBiasSlopeFactor;
        internal float lineWidth;
    }
}