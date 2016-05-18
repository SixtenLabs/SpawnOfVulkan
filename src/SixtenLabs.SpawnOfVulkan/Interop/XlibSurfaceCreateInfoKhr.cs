using System;

namespace SixtenLabs.SpawnOfVulkan
{
    unsafe internal struct XlibSurfaceCreateInfoKhr
    {
        internal StructureType sType;
        internal IntPtr pNext;
        internal uint flags;
        internal IntPtr dpy;
        internal IntPtr window;
    }
}