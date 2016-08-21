using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct SparseImageMemoryBindInfo
    {
        internal ImageHandle Image;
        internal uint BindCount;
        internal SparseImageMemoryBind PBinds;
    }
}