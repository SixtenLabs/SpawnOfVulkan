using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct SparseImageMemoryRequirements
    {
        internal SparseImageFormatProperties FormatProperties;
        internal uint ImageMipTailFirstLod;
        internal ulong ImageMipTailSize;
        internal ulong ImageMipTailOffset;
        internal ulong ImageMipTailStride;
    }
}