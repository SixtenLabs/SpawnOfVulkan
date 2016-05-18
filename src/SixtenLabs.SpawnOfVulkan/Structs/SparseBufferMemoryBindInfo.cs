using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct SparseBufferMemoryBindInfo
    {
        internal Buffer buffer;
        internal uint bindCount;
        internal SparseMemoryBind pBinds;
    }
}