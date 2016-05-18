using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct SpecializationInfo
    {
        internal uint mapEntryCount;
        internal SpecializationMapEntry pMapEntries;
        internal UIntPtr dataSize;
        internal IntPtr pData;
    }
}