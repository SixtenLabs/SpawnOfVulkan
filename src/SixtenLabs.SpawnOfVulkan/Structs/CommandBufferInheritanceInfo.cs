using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct CommandBufferInheritanceInfo
    {
        internal StructureType SType;
        internal IntPtr PNext;
        internal RenderPass RenderPass;
        internal uint Subpass;
        internal Framebuffer Framebuffer;
        internal uint OcclusionQueryEnable;
        internal QueryControlFlags QueryFlags;
        internal QueryPipelineStatisticFlags PipelineStatistics;
    }
}