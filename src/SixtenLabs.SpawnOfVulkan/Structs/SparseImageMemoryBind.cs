using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct SparseImageMemoryBind
    {
        internal ImageSubresource subresource;
        internal Offset3D offset;
        internal Extent3D extent;
        internal DeviceMemory memory;
        internal ulong memoryOffset;
        internal SparseMemoryBindFlags flags;
    }
}