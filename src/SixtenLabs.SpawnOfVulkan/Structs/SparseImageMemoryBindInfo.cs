using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct SparseImageMemoryBindInfo
    {
        internal Image Image;
        internal uint BindCount;
        internal SparseImageMemoryBind PBinds;
    }
}