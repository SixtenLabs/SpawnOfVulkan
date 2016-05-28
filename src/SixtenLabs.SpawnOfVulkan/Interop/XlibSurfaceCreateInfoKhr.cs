using System;

namespace SixtenLabs.SpawnOfVulkan
{
    unsafe public struct XlibSurfaceCreateInfoKhr
    {
        internal StructureType sType;
        internal IntPtr pNext;
        internal uint flags;
        internal IntPtr dpy;
        internal IntPtr window;
    }
}