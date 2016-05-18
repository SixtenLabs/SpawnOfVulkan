using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct SparseImageMemoryRequirements
    {
        internal SparseImageFormatProperties formatProperties;
        internal uint imageMipTailFirstLod;
        internal ulong imageMipTailSize;
        internal ulong imageMipTailOffset;
        internal ulong imageMipTailStride;
    }
}