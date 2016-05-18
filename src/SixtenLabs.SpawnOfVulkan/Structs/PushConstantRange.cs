using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct PushConstantRange
    {
        internal ShaderStageFlags stageFlags;
        internal uint offset;
        internal uint size;
    }
}