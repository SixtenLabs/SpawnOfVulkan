using System;

namespace SixtenLabs.SpawnOfVulkan
{
    [Flags()]
    public enum BufferCreateFlags : int
    {
        /// <summary>
                /// Buffer should support sparse backing
                /// </summary>
        BufferCreateSparseBindingBit = 0x1,
        /// <summary>
                /// Buffer should support sparse backing with partial residency
                /// </summary>
        BufferCreateSparseResidencyBit = 0x2,
        /// <summary>
                /// Buffer should support constent data access to physical memory ranges mapped into multiple locations of sparse buffers
                /// </summary>
        BufferCreateSparseAliasedBit = 0x4
    }
}