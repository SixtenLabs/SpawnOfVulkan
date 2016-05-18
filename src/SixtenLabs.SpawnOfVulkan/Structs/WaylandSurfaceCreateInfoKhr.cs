using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct WaylandSurfaceCreateInfoKhr
    {
        internal StructureType sType;
        internal IntPtr pNext;
        internal uint flags;
        internal IntPtr display;
        internal IntPtr surface;
    }
}