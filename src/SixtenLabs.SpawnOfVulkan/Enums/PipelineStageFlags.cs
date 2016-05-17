using System;

namespace SixtenLabs.SpawnOfVulkan
{
    [Flags]
    public enum PipelineStageFlags : int
    {
        PipelineStageTopOfPipeBit = 0x1,
        PipelineStageDrawIndirectBit = 0x2,
        PipelineStageVertexInputBit = 0x4,
        PipelineStageVertexShaderBit = 0x8,
        PipelineStageTessellationControlShaderBit = 0x10,
        PipelineStageTessellationEvaluationShaderBit = 0x20,
        PipelineStageGeometryShaderBit = 0x40,
        PipelineStageFragmentShaderBit = 0x80,
        PipelineStageEarlyFragmentTestsBit = 0x100,
        PipelineStageLateFragmentTestsBit = 0x200,
        PipelineStageColorAttachmentOutputBit = 0x400,
        PipelineStageComputeShaderBit = 0x800,
        PipelineStageTransferBit = 0x1000,
        PipelineStageBottomOfPipeBit = 0x2000,
        PipelineStageHostBit = 0x4000,
        PipelineStageAllGraphicsBit = 0x8000,
        PipelineStageAllCommandsBit = 0x10000
    }
}