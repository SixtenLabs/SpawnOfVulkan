using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct SparseImageFormatProperties
    {
        internal ImageAspectFlags AspectMask;
        internal Extent3D ImageGranularity;
        internal SparseImageFormatFlags Flags;
    }
}