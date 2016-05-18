using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct SparseImageFormatProperties
    {
        internal ImageAspectFlags aspectMask;
        internal Extent3D imageGranularity;
        internal SparseImageFormatFlags flags;
    }
}