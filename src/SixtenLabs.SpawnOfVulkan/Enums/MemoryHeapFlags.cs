using System;

namespace SixtenLabs.SpawnOfVulkan
{
    [Flags()]
    public enum MemoryHeapFlags : int
    {
        /// <summary>
        /// If set, heap represents device memory
        /// </summary>
        MemoryHeapDeviceLocalBit = 0x1
    }
}