using System;

namespace SixtenLabs.SpawnOfVulkan
{
    [Flags()]
    public enum ShaderStageFlags : int
    {
        ShaderStageVertexBit = 0x1,
        ShaderStageTessellationControlBit = 0x2,
        ShaderStageTessellationEvaluationBit = 0x4,
        ShaderStageGeometryBit = 0x8,
        ShaderStageFragmentBit = 0x10,
        ShaderStageComputeBit = 0x20,
        ShaderStageAllGraphics = 0x0000001F,
        ShaderStageAll = 0x7FFFFFFF
    }
}