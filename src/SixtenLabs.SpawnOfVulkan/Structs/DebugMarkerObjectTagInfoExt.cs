using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct DebugMarkerObjectTagInfoExt
    {
        internal StructureType SType;
        internal IntPtr PNext;
        internal DebugReportObjectTypeExt ObjectType;
        internal ulong Handle;
        internal ulong TagName;
        internal UIntPtr TagSize;
        internal IntPtr PTag;
    }
}