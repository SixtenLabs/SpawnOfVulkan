using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct Win32SurfaceCreateInfoKhr
    {
        internal StructureType sType;
        internal IntPtr pNext;
        internal uint flags;
        internal IntPtr hinstance;
        internal IntPtr hwnd;
    }
}