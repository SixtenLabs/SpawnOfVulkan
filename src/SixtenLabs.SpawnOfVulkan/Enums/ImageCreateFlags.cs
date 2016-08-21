using System;

namespace SixtenLabs.SpawnOfVulkan
{
    [Flags()]
    public enum ImageCreateFlags : int
    {
        /// <summary>
                /// Image should support sparse backing
                /// </summary>
        ImageCreateSparseBindingBit = 0x1,
        /// <summary>
                /// Image should support sparse backing with partial residency
                /// </summary>
        ImageCreateSparseResidencyBit = 0x2,
        /// <summary>
                /// Image should support constent data access to physical memory ranges mapped into multiple locations of sparse images
                /// </summary>
        ImageCreateSparseAliasedBit = 0x4,
        /// <summary>
                /// Allows image views to have different format than the base image
                /// </summary>
        ImageCreateMutableFormatBit = 0x8,
        /// <summary>
                /// Allows creating image views with cube type from the created image
                /// </summary>
        ImageCreateCubeCompatibleBit = 0x10
    }
}