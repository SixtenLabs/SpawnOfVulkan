using System;

namespace SixtenLabs.SpawnOfVulkan
{
    [Flags()]
    public enum CommandPoolResetFlags : int
    {
        /// <summary>
        /// Release resources owned by the pool
        /// </summary>
        CommandPoolResetReleaseResourcesBit = 0x1
    }
}