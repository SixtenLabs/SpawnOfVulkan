using System;

namespace SixtenLabs.SpawnOfVulkan
{
    [Flags()]
    public enum MemoryPropertyFlags : int
    {
        /// <summary>
                /// If otherwise stated, then allocate memory on device
                /// </summary>
        MemoryPropertyDeviceLocalBit = 0x1,
        /// <summary>
                /// Memory is mappable by host
                /// </summary>
        MemoryPropertyHostVisibleBit = 0x2,
        /// <summary>
                /// Memory will have i/o coherency. If not set, application may need to use vkFlushMappedMemoryRanges and vkInvalidateMappedMemoryRanges to flush/invalidate host cache
                /// </summary>
        MemoryPropertyHostCoherentBit = 0x4,
        /// <summary>
                /// Memory will be cached by the host
                /// </summary>
        MemoryPropertyHostCachedBit = 0x8,
        /// <summary>
                /// Memory may be allocated by the driver when it is required
                /// </summary>
        MemoryPropertyLazilyAllocatedBit = 0x10
    }
}