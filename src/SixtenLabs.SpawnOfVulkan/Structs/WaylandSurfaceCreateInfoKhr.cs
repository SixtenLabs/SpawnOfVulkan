using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct WaylandSurfaceCreateInfoKhr
    {
        internal StructureType SType;
        internal IntPtr PNext;
        internal WaylandSurfaceCreateFlagsKhr Flags;
        internal IntPtr Display;
        internal IntPtr Surface;
    }
}