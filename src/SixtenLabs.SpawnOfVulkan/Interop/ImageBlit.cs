using System;

namespace SixtenLabs.SpawnOfVulkan
{
    unsafe public struct ImageBlit
    {
        internal ImageSubresourceLayers srcSubresource;
        internal Offset3D srcOffsets;
        internal ImageSubresourceLayers dstSubresource;
        internal Offset3D dstOffsets;
    }
}