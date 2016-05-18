using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct PipelineCacheCreateInfo
    {
        internal StructureType sType;
        internal IntPtr pNext;
        internal uint flags;
        internal UIntPtr initialDataSize;
        internal IntPtr pInitialData;
    }
}