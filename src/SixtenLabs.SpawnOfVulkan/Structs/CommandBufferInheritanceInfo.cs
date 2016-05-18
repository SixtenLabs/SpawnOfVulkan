using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct CommandBufferInheritanceInfo
    {
        internal StructureType sType;
        internal IntPtr pNext;
        internal RenderPass renderPass;
        internal uint subpass;
        internal Framebuffer framebuffer;
        internal uint occlusionQueryEnable;
        internal QueryControlFlags queryFlags;
        internal QueryPipelineStatisticFlags pipelineStatistics;
    }
}