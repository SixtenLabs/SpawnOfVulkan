using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct ImageBlit
    {
        internal ImageSubresourceLayers SrcSubresource;
        internal Offset3D SrcOffsets;
        internal ImageSubresourceLayers DstSubresource;
        internal Offset3D DstOffsets;
    }
}