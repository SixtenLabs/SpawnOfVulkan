using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct MirSurfaceCreateInfoKhr
    {
        internal StructureType SType;
        internal IntPtr PNext;
        internal MirSurfaceCreateFlagsKhr Flags;
        internal IntPtr Connection;
        internal IntPtr MirSurface;
    }
}