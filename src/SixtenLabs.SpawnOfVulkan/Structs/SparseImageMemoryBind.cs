using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct SparseImageMemoryBind
    {
        internal ImageSubresource Subresource;
        internal Offset3D Offset;
        internal Extent3D Extent;
        internal DeviceMemoryHandle Memory;
        internal ulong MemoryOffset;
        internal SparseMemoryBindFlags Flags;
    }
}