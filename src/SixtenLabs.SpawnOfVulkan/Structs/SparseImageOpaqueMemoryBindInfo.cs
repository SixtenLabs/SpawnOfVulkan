using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct SparseImageOpaqueMemoryBindInfo
    {
        internal Image image;
        internal uint bindCount;
        internal SparseMemoryBind pBinds;
    }
}