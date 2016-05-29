using System;

namespace SixtenLabs.SpawnOfVulkan
{
    [Flags]
    public enum CommandBufferResetFlags : int
    {
        CommandBufferResetReleaseResourcesBit = 0x1
    }
}