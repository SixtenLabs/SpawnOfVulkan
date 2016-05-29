using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct SparseImageOpaqueMemoryBindInfo
    {
        internal Image Image;
        internal uint BindCount;
        internal SparseMemoryBind PBinds;
    }
}