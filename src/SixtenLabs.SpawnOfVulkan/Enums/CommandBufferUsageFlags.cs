using System;

namespace SixtenLabs.SpawnOfVulkan
{
    [Flags()]
    public enum CommandBufferUsageFlags : int
    {
        CommandBufferUsageOneTimeSubmitBit = 0x1,
        CommandBufferUsageRenderPassContinueBit = 0x2,
        /// <summary>
        /// Command buffer may be submitted/executed more than once simultaneously
        /// </summary>
        CommandBufferUsageSimultaneousUseBit = 0x4
    }
}