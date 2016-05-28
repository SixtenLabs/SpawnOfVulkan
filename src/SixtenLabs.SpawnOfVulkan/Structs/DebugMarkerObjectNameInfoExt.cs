using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct DebugMarkerObjectNameInfoExt
    {
        internal StructureType sType;
        internal IntPtr pNext;
        internal DebugReportObjectTypeExt objectType;
        internal ulong Handle;
        internal string pObjectName;
    }
}