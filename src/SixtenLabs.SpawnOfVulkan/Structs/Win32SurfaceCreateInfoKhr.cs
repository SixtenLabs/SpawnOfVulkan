using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct Win32SurfaceCreateInfoKhr
    {
        internal StructureType SType;
        internal IntPtr PNext;
        internal Win32SurfaceCreateFlagsKhr Flags;
        internal IntPtr Hinstance;
        internal IntPtr Hwnd;
    }
}