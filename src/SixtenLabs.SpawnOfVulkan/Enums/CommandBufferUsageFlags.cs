using System;

namespace SixtenLabs.SpawnOfVulkan
{
    [Flags]
    public enum CommandBufferUsageFlags : int
    {
        CommandBufferUsageOneTimeSubmitBit = 0x1,
        CommandBufferUsageRenderPassContinueBit = 0x2,
        CommandBufferUsageSimultaneousUseBit = 0x4
    }
}