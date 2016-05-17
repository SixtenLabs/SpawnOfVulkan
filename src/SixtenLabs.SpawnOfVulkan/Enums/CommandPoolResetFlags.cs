using System;

namespace SixtenLabs.SpawnOfVulkan
{
    [Flags]
    public enum CommandPoolResetFlags : int
    {
        CommandPoolResetReleaseResourcesBit = 0x1
    }
}