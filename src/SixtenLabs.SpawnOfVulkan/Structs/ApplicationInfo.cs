using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct ApplicationInfo
    {
        internal StructureType SType;
        internal IntPtr PNext;
        internal byte PApplicationName;
        internal uint ApplicationVersion;
        internal byte PEngineName;
        internal uint EngineVersion;
        internal uint ApiVersion;
    }
}