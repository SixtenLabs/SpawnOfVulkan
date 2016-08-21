﻿using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct ImageViewCreateInfo
    {
        internal StructureType SType;
        internal IntPtr PNext;
        internal ImageViewCreateFlags Flags;
        internal ImageHandle Image;
        internal ImageViewType ViewType;
        internal Format Format;
        internal ComponentMapping Components;
        internal ImageSubresourceRange SubresourceRange;
    }
}