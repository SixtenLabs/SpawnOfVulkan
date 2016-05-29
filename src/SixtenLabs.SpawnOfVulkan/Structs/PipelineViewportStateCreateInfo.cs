using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct PipelineViewportStateCreateInfo
    {
        internal StructureType SType;
        internal IntPtr PNext;
        internal PipelineViewportStateCreateFlags Flags;
        internal uint ViewportCount;
        internal Viewport PViewports;
        internal uint ScissorCount;
        internal Rect2D PScissors;
    }
}