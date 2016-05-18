using System;

namespace SixtenLabs.SpawnOfVulkan
{
    unsafe internal struct AndroidSurfaceCreateInfoKhr
    {
        internal StructureType sType;
        internal IntPtr pNext;
        internal uint flags;
        internal IntPtr window;
    }
}