using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct SparseBufferMemoryBindInfo
    {
        internal BufferHandle Buffer;
        internal uint BindCount;
        internal SparseMemoryBind PBinds;
    }
}