using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct SubpassDependency
    {
        internal uint srcSubpass;
        internal uint dstSubpass;
        internal PipelineStageFlags srcStageMask;
        internal PipelineStageFlags dstStageMask;
        internal AccessFlags srcAccessMask;
        internal AccessFlags dstAccessMask;
        internal DependencyFlags dependencyFlags;
    }
}