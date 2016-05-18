using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct BufferImageCopy
    {
        internal ulong bufferOffset;
        internal uint bufferRowLength;
        internal uint bufferImageHeight;
        internal ImageSubresourceLayers imageSubresource;
        internal Offset3D imageOffset;
        internal Extent3D imageExtent;
    }
}