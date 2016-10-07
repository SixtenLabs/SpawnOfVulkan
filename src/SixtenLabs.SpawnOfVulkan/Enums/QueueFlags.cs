using System;

namespace SixtenLabs.SpawnOfVulkan
{
    [Flags()]
    public enum QueueFlags : int
    {
        /// <summary>
        /// Queue supports graphics operations
        /// </summary>
        QueueGraphicsBit = 0x1,
        /// <summary>
        /// Queue supports compute operations
        /// </summary>
        QueueComputeBit = 0x2,
        /// <summary>
        /// Queue supports transfer operations
        /// </summary>
        QueueTransferBit = 0x4,
        /// <summary>
        /// Queue supports sparse resource memory management operations
        /// </summary>
        QueueSparseBindingBit = 0x8
    }
}