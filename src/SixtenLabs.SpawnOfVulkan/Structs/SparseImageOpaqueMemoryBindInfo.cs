using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct SparseImageOpaqueMemoryBindInfo
    {
        internal ImageHandle Image;
        internal uint BindCount;
        internal SparseMemoryBind PBinds;
    }
}