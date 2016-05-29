using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct PushConstantRange
    {
        internal ShaderStageFlags StageFlags;
        internal uint Offset;
        internal uint Size;
    }
}