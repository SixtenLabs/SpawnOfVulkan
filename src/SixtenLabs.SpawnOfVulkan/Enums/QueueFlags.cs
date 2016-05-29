using System;

namespace SixtenLabs.SpawnOfVulkan
{
    [Flags]
    public enum QueueFlags : int
    {
        QueueGraphicsBit = 0x1,
        QueueComputeBit = 0x2,
        QueueTransferBit = 0x4,
        QueueSparseBindingBit = 0x8
    }
}