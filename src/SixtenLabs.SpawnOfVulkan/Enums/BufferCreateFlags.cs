using System;

namespace SixtenLabs.SpawnOfVulkan
{
    [Flags]
    public enum BufferCreateFlags : int
    {
        BufferCreateSparseBindingBit = 0x1,
        BufferCreateSparseResidencyBit = 0x2,
        BufferCreateSparseAliasedBit = 0x4
    }
}