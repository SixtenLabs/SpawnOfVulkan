using System;

namespace SixtenLabs.SpawnOfVulkan
{
    [Flags]
    public enum SparseImageFormatFlags : int
    {
        SparseImageFormatSingleMiptailBit = 0x1,
        SparseImageFormatAlignedMipSizeBit = 0x2,
        SparseImageFormatNonstandardBlockSizeBit = 0x4
    }
}