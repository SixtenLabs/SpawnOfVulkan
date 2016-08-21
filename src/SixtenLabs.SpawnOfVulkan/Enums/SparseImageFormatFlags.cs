﻿using System;

namespace SixtenLabs.SpawnOfVulkan
{
    [Flags()]
    public enum SparseImageFormatFlags : int
    {
        /// <summary>
                /// Image uses a single miptail region for all array layers
                /// </summary>
        SparseImageFormatSingleMiptailBit = 0x1,
        /// <summary>
                /// Image requires mip level dimensions to be an integer multiple of the sparse image block dimensions for non-miptail levels.
                /// </summary>
        SparseImageFormatAlignedMipSizeBit = 0x2,
        /// <summary>
                /// Image uses a non-standard sparse image block dimensions
                /// </summary>
        SparseImageFormatNonstandardBlockSizeBit = 0x4
    }
}