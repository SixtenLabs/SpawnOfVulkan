using System;

namespace SixtenLabs.SpawnOfVulkan
{
    [Flags()]
    public enum ImageUsageFlags : int
    {
        /// <summary>
                /// Can be used as a source of transfer operations
                /// </summary>
        ImageUsageTransferSrcBit = 0x1,
        /// <summary>
                /// Can be used as a destination of transfer operations
                /// </summary>
        ImageUsageTransferDstBit = 0x2,
        /// <summary>
                /// Can be sampled from (SAMPLED_IMAGE and COMBINED_IMAGE_SAMPLER descriptor types)
                /// </summary>
        ImageUsageSampledBit = 0x4,
        /// <summary>
                /// Can be used as storage image (STORAGE_IMAGE descriptor type)
                /// </summary>
        ImageUsageStorageBit = 0x8,
        /// <summary>
                /// Can be used as framebuffer color attachment
                /// </summary>
        ImageUsageColorAttachmentBit = 0x10,
        /// <summary>
                /// Can be used as framebuffer depth/stencil attachment
                /// </summary>
        ImageUsageDepthStencilAttachmentBit = 0x20,
        /// <summary>
                /// Image data not needed outside of rendering
                /// </summary>
        ImageUsageTransientAttachmentBit = 0x40,
        /// <summary>
                /// Can be used as framebuffer input attachment
                /// </summary>
        ImageUsageInputAttachmentBit = 0x80
    }
}