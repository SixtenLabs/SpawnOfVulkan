using System;

namespace SixtenLabs.SpawnOfVulkan
{
    [Flags()]
    public enum FormatFeatureFlags : int
    {
        /// <summary>
                /// Format can be used for sampled images (SAMPLED_IMAGE and COMBINED_IMAGE_SAMPLER descriptor types)
                /// </summary>
        FormatFeatureSampledImageBit = 0x1,
        /// <summary>
                /// Format can be used for storage images (STORAGE_IMAGE descriptor type)
                /// </summary>
        FormatFeatureStorageImageBit = 0x2,
        /// <summary>
                /// Format supports atomic operations in case it is used for storage images
                /// </summary>
        FormatFeatureStorageImageAtomicBit = 0x4,
        /// <summary>
                /// Format can be used for uniform texel buffers (TBOs)
                /// </summary>
        FormatFeatureUniformTexelBufferBit = 0x8,
        /// <summary>
                /// Format can be used for storage texel buffers (IBOs)
                /// </summary>
        FormatFeatureStorageTexelBufferBit = 0x10,
        /// <summary>
                /// Format supports atomic operations in case it is used for storage texel buffers
                /// </summary>
        FormatFeatureStorageTexelBufferAtomicBit = 0x20,
        /// <summary>
                /// Format can be used for vertex buffers (VBOs)
                /// </summary>
        FormatFeatureVertexBufferBit = 0x40,
        /// <summary>
                /// Format can be used for color attachment images
                /// </summary>
        FormatFeatureColorAttachmentBit = 0x80,
        /// <summary>
                /// Format supports blending in case it is used for color attachment images
                /// </summary>
        FormatFeatureColorAttachmentBlendBit = 0x100,
        /// <summary>
                /// Format can be used for depth/stencil attachment images
                /// </summary>
        FormatFeatureDepthStencilAttachmentBit = 0x200,
        /// <summary>
                /// Format can be used as the source image of blits with vkCmdBlitImage
                /// </summary>
        FormatFeatureBlitSrcBit = 0x400,
        /// <summary>
                /// Format can be used as the destination image of blits with vkCmdBlitImage
                /// </summary>
        FormatFeatureBlitDstBit = 0x800,
        /// <summary>
                /// Format can be filtered with VK_FILTER_LINEAR when being sampled
                /// </summary>
        FormatFeatureSampledImageFilterLinearBit = 0x1000,
        FormatFeatureSampledImageFilterCubicBitImg = 0x2000
    }
}