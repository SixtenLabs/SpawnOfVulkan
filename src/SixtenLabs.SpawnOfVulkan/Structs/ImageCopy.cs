﻿using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct ImageCopy
    {
        internal ImageSubresourceLayers SrcSubresource;
        internal Offset3D SrcOffset;
        internal ImageSubresourceLayers DstSubresource;
        internal Offset3D DstOffset;
        internal Extent3D Extent;
    }
}