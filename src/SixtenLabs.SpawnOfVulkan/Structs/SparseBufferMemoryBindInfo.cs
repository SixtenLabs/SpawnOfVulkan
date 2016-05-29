using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct SparseBufferMemoryBindInfo
    {
        internal Buffer Buffer;
        internal uint BindCount;
        internal SparseMemoryBind PBinds;
    }
}