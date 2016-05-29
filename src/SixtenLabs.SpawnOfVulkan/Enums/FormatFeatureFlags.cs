using System;

namespace SixtenLabs.SpawnOfVulkan
{
    [Flags]
    public enum FormatFeatureFlags : int
    {
        FormatFeatureSampledImageBit = 0x1,
        FormatFeatureStorageImageBit = 0x2,
        FormatFeatureStorageImageAtomicBit = 0x4,
        FormatFeatureUniformTexelBufferBit = 0x8,
        FormatFeatureStorageTexelBufferBit = 0x10,
        FormatFeatureStorageTexelBufferAtomicBit = 0x20,
        FormatFeatureVertexBufferBit = 0x40,
        FormatFeatureColorAttachmentBit = 0x80,
        FormatFeatureColorAttachmentBlendBit = 0x100,
        FormatFeatureDepthStencilAttachmentBit = 0x200,
        FormatFeatureBlitSrcBit = 0x400,
        FormatFeatureBlitDstBit = 0x800,
        FormatFeatureSampledImageFilterLinearBit = 0x1000,
        FormatFeatureSampledImageFilterCubicBitImg = 0x2000
    }
}