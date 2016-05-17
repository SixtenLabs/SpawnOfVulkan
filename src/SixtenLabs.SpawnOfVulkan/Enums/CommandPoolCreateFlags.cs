using System;

namespace SixtenLabs.SpawnOfVulkan
{
    [Flags]
    public enum CommandPoolCreateFlags : int
    {
        CommandPoolCreateTransientBit = 0x1,
        CommandPoolCreateResetCommandBufferBit = 0x2
    }
}