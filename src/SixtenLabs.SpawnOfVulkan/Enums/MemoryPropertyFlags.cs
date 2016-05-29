using System;

namespace SixtenLabs.SpawnOfVulkan
{
    [Flags]
    public enum MemoryPropertyFlags : int
    {
        MemoryPropertyDeviceLocalBit = 0x1,
        MemoryPropertyHostVisibleBit = 0x2,
        MemoryPropertyHostCoherentBit = 0x4,
        MemoryPropertyHostCachedBit = 0x8,
        MemoryPropertyLazilyAllocatedBit = 0x10
    }
}