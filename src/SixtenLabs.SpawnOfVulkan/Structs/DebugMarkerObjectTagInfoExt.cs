using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct DebugMarkerObjectTagInfoExt
    {
        internal StructureType sType;
        internal IntPtr pNext;
        internal DebugReportObjectTypeExt objectType;
        internal ulong Handle;
        internal ulong tagName;
        internal UIntPtr tagSize;
        internal IntPtr pTag;
    }
}