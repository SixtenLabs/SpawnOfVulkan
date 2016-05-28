using System;

namespace SixtenLabs.SpawnOfVulkan
{
    unsafe public struct DebugMarkerMarkerInfoExt
    {
        internal StructureType sType;
        internal IntPtr pNext;
        internal string pMarkerName;
        internal unsafe fixed float color[4];
    }
}