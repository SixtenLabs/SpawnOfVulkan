using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct PipelineCacheCreateInfo
    {
        internal StructureType SType;
        internal IntPtr PNext;
        internal PipelineCacheCreateFlags Flags;
        internal UIntPtr InitialDataSize;
        internal IntPtr PInitialData;
    }
}