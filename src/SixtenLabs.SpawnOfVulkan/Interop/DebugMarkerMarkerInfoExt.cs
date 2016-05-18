using System;

namespace SixtenLabs.SpawnOfVulkan
{
    unsafe internal struct DebugMarkerMarkerInfoExt
    {
        internal StructureType sType;
        internal IntPtr pNext;
        internal char pMarkerName;
        internal unsafe fixed float color[4];
    }
}