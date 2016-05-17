using System;

namespace SixtenLabs.SpawnOfVulkan
{
    [Flags]
    public enum PipelineCreateFlags : int
    {
        PipelineCreateDisableOptimizationBit = 0x1,
        PipelineCreateAllowDerivativesBit = 0x2,
        PipelineCreateDerivativeBit = 0x4
    }
}