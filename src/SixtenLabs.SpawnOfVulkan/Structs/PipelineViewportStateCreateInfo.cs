using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct PipelineViewportStateCreateInfo
    {
        internal StructureType sType;
        internal IntPtr pNext;
        internal uint flags;
        internal uint viewportCount;
        internal Viewport pViewports;
        internal uint scissorCount;
        internal Rect2D pScissors;
    }
}