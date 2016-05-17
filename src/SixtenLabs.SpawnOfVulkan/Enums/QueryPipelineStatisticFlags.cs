using System;

namespace SixtenLabs.SpawnOfVulkan
{
    [Flags]
    public enum QueryPipelineStatisticFlags : int
    {
        QueryPipelineStatisticInputAssemblyVerticesBit = 0x1,
        QueryPipelineStatisticInputAssemblyPrimitivesBit = 0x2,
        QueryPipelineStatisticVertexShaderInvocationsBit = 0x4,
        QueryPipelineStatisticGeometryShaderInvocationsBit = 0x8,
        QueryPipelineStatisticGeometryShaderPrimitivesBit = 0x10,
        QueryPipelineStatisticClippingInvocationsBit = 0x20,
        QueryPipelineStatisticClippingPrimitivesBit = 0x40,
        QueryPipelineStatisticFragmentShaderInvocationsBit = 0x80,
        QueryPipelineStatisticTessellationControlShaderPatchesBit = 0x100,
        QueryPipelineStatisticTessellationEvaluationShaderInvocationsBit = 0x200,
        QueryPipelineStatisticComputeShaderInvocationsBit = 0x400
    }
}