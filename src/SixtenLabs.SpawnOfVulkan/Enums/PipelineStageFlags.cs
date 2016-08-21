using System;

namespace SixtenLabs.SpawnOfVulkan
{
    [Flags()]
    public enum PipelineStageFlags : int
    {
        /// <summary>
                /// Before subsequent commands are processed
                /// </summary>
        PipelineStageTopOfPipeBit = 0x1,
        /// <summary>
                /// Draw/DispatchIndirect command fetch
                /// </summary>
        PipelineStageDrawIndirectBit = 0x2,
        /// <summary>
                /// Vertex/index fetch
                /// </summary>
        PipelineStageVertexInputBit = 0x4,
        /// <summary>
                /// Vertex shading
                /// </summary>
        PipelineStageVertexShaderBit = 0x8,
        /// <summary>
                /// Tessellation control shading
                /// </summary>
        PipelineStageTessellationControlShaderBit = 0x10,
        /// <summary>
                /// Tessellation evaluation shading
                /// </summary>
        PipelineStageTessellationEvaluationShaderBit = 0x20,
        /// <summary>
                /// Geometry shading
                /// </summary>
        PipelineStageGeometryShaderBit = 0x40,
        /// <summary>
                /// Fragment shading
                /// </summary>
        PipelineStageFragmentShaderBit = 0x80,
        /// <summary>
                /// Early fragment (depth and stencil) tests
                /// </summary>
        PipelineStageEarlyFragmentTestsBit = 0x100,
        /// <summary>
                /// Late fragment (depth and stencil) tests
                /// </summary>
        PipelineStageLateFragmentTestsBit = 0x200,
        /// <summary>
                /// Color attachment writes
                /// </summary>
        PipelineStageColorAttachmentOutputBit = 0x400,
        /// <summary>
                /// Compute shading
                /// </summary>
        PipelineStageComputeShaderBit = 0x800,
        /// <summary>
                /// Transfer/copy operations
                /// </summary>
        PipelineStageTransferBit = 0x1000,
        /// <summary>
                /// After previous commands have completed
                /// </summary>
        PipelineStageBottomOfPipeBit = 0x2000,
        /// <summary>
                /// Indicates host (CPU) is a source/sink of the dependency
                /// </summary>
        PipelineStageHostBit = 0x4000,
        /// <summary>
                /// All stages of the graphics pipeline
                /// </summary>
        PipelineStageAllGraphicsBit = 0x8000,
        /// <summary>
                /// All stages supported on the queue
                /// </summary>
        PipelineStageAllCommandsBit = 0x10000
    }
}