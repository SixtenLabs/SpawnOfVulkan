using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct BufferImageCopy
    {
        internal ulong BufferOffset;
        internal uint BufferRowLength;
        internal uint BufferImageHeight;
        internal ImageSubresourceLayers ImageSubresource;
        internal Offset3D ImageOffset;
        internal Extent3D ImageExtent;
    }
}