using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct SpecializationInfo
    {
        internal uint MapEntryCount;
        internal SpecializationMapEntry PMapEntries;
        internal UIntPtr DataSize;
        internal IntPtr PData;
    }
}