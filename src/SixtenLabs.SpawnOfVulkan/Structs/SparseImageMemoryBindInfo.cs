using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct SparseImageMemoryBindInfo
    {
        internal Image image;
        internal uint bindCount;
        internal SparseImageMemoryBind pBinds;
    }
}