using System;

namespace SixtenLabs.SpawnOfVulkan
{
    [Flags]
    public enum ImageCreateFlags : int
    {
        ImageCreateSparseBindingBit = 0x1,
        ImageCreateSparseResidencyBit = 0x2,
        ImageCreateSparseAliasedBit = 0x4,
        ImageCreateMutableFormatBit = 0x8,
        ImageCreateCubeCompatibleBit = 0x10
    }
}