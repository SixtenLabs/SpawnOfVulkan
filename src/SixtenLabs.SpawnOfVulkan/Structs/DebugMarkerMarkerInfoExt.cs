using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct DebugMarkerMarkerInfoExt
    {
        internal StructureType SType;
        internal IntPtr PNext;
        internal byte PMarkerName;
        internal unsafe fixed float [4];
    }
}