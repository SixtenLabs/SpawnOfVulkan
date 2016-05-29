using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct AndroidSurfaceCreateInfoKhr
    {
        internal StructureType SType;
        internal IntPtr PNext;
        internal AndroidSurfaceCreateFlagsKhr Flags;
        internal IntPtr Window;
    }
}