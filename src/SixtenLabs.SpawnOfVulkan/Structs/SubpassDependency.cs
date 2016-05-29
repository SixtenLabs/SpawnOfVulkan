using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct SubpassDependency
    {
        internal uint SrcSubpass;
        internal uint DstSubpass;
        internal PipelineStageFlags SrcStageMask;
        internal PipelineStageFlags DstStageMask;
        internal AccessFlags SrcAccessMask;
        internal AccessFlags DstAccessMask;
        internal DependencyFlags DependencyFlags;
    }
}