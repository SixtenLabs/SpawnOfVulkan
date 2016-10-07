using System;

namespace SixtenLabs.SpawnOfVulkan
{
    [Flags()]
    public enum QueryPipelineStatisticFlags : int
    {
        /// <summary>
        /// Optional
        /// </summary>
        QueryPipelineStatisticInputAssemblyVerticesBit = 0x1,
        /// <summary>
        /// Optional
        /// </summary>
        QueryPipelineStatisticInputAssemblyPrimitivesBit = 0x2,
        /// <summary>
        /// Optional
        /// </summary>
        QueryPipelineStatisticVertexShaderInvocationsBit = 0x4,
        /// <summary>
        /// Optional
        /// </summary>
        QueryPipelineStatisticGeometryShaderInvocationsBit = 0x8,
        /// <summary>
        /// Optional
        /// </summary>
        QueryPipelineStatisticGeometryShaderPrimitivesBit = 0x10,
        /// <summary>
        /// Optional
        /// </summary>
        QueryPipelineStatisticClippingInvocationsBit = 0x20,
        /// <summary>
        /// Optional
        /// </summary>
        QueryPipelineStatisticClippingPrimitivesBit = 0x40,
        /// <summary>
        /// Optional
        /// </summary>
        QueryPipelineStatisticFragmentShaderInvocationsBit = 0x80,
        /// <summary>
        /// Optional
        /// </summary>
        QueryPipelineStatisticTessellationControlShaderPatchesBit = 0x100,
        /// <summary>
        /// Optional
        /// </summary>
        QueryPipelineStatisticTessellationEvaluationShaderInvocationsBit = 0x200,
        /// <summary>
        /// Optional
        /// </summary>
        QueryPipelineStatisticComputeShaderInvocationsBit = 0x400
    }
}