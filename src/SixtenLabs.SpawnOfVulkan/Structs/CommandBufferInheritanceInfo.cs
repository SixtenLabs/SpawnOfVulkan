using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct CommandBufferInheritanceInfo
    {
        internal StructureType SType;
        internal IntPtr PNext;
        internal RenderPassHandle RenderPass;
        internal uint Subpass;
        internal FramebufferHandle Framebuffer;
        internal uint OcclusionQueryEnable;
        internal QueryControlFlags QueryFlags;
        internal QueryPipelineStatisticFlags PipelineStatistics;
    }
}