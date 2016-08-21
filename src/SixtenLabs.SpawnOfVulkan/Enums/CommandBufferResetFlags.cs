using System;

namespace SixtenLabs.SpawnOfVulkan
{
    [Flags()]
    public enum CommandBufferResetFlags : int
    {
        /// <summary>
                /// Release resources owned by the buffer
                /// </summary>
        CommandBufferResetReleaseResourcesBit = 0x1
    }
}