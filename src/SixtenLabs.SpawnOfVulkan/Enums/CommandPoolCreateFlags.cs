using System;

namespace SixtenLabs.SpawnOfVulkan
{
    [Flags()]
    public enum CommandPoolCreateFlags : int
    {
        /// <summary>
                /// Command buffers have a short lifetime
                /// </summary>
        CommandPoolCreateTransientBit = 0x1,
        /// <summary>
                /// Command buffers may release their memory individually
                /// </summary>
        CommandPoolCreateResetCommandBufferBit = 0x2
    }
}