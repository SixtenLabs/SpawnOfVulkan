﻿using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct ImageCopy
    {
        internal ImageSubresourceLayers srcSubresource;
        internal Offset3D srcOffset;
        internal ImageSubresourceLayers dstSubresource;
        internal Offset3D dstOffset;
        internal Extent3D extent;
    }
}