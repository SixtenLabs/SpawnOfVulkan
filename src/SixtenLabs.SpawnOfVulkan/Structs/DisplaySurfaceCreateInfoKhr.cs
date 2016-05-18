using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct DisplaySurfaceCreateInfoKhr
    {
        internal StructureType sType;
        internal IntPtr pNext;
        internal uint flags;
        internal DisplayModeKhr displayMode;
        internal uint planeIndex;
        internal uint planeStackIndex;
        internal SurfaceTransformFlagsKhr transform;
        internal float globalAlpha;
        internal DisplayPlaneAlphaFlagsKhr alphaMode;
        internal Extent2D imageExtent;
    }
}