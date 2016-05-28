using System;

namespace SixtenLabs.SpawnOfVulkan
{
    unsafe public struct AndroidSurfaceCreateInfoKhr
    {
        internal StructureType sType;
        internal IntPtr pNext;
        internal uint flags;
        internal IntPtr window;
    }
}