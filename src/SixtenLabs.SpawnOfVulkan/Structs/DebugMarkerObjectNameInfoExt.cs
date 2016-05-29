using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct DebugMarkerObjectNameInfoExt
    {
        internal StructureType SType;
        internal IntPtr PNext;
        internal DebugReportObjectTypeExt ObjectType;
        internal ulong Handle;
        internal byte PObjectName;
    }
}