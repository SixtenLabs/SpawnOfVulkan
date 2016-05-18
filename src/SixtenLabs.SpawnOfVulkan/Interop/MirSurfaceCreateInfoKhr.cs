using System;

namespace SixtenLabs.SpawnOfVulkan
{
    unsafe internal struct MirSurfaceCreateInfoKhr
    {
        internal StructureType sType;
        internal IntPtr pNext;
        internal uint flags;
        internal IntPtr connection;
        internal IntPtr mirSurface;
    }
}