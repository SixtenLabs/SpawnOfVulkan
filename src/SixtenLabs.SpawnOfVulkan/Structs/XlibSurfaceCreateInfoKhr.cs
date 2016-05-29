using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct XlibSurfaceCreateInfoKhr
    {
        internal StructureType SType;
        internal IntPtr PNext;
        internal XlibSurfaceCreateFlagsKhr Flags;
        internal IntPtr Dpy;
        internal IntPtr Window;
    }
}