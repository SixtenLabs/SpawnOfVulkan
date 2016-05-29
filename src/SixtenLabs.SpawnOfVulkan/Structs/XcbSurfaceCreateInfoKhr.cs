using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct XcbSurfaceCreateInfoKhr
    {
        internal StructureType SType;
        internal IntPtr PNext;
        internal XcbSurfaceCreateFlagsKhr Flags;
        internal IntPtr Connection;
        internal IntPtr Window;
    }
}