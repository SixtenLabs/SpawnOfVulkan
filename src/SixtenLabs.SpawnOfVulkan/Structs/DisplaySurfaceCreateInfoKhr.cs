using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct DisplaySurfaceCreateInfoKhr
    {
        internal StructureType SType;
        internal IntPtr PNext;
        internal DisplaySurfaceCreateFlagsKhr Flags;
        internal DisplayModeKhrHandle DisplayMode;
        internal uint PlaneIndex;
        internal uint PlaneStackIndex;
        internal SurfaceTransformFlagsKhr Transform;
        internal float GlobalAlpha;
        internal DisplayPlaneAlphaFlagsKhr AlphaMode;
        internal Extent2D ImageExtent;
    }
}