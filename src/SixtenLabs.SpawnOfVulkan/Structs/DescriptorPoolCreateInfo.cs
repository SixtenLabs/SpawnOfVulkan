using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct DescriptorPoolCreateInfo
    {
        internal StructureType SType;
        internal IntPtr PNext;
        internal DescriptorPoolCreateFlags Flags;
        internal uint MaxSets;
        internal uint PoolSizeCount;
        internal DescriptorPoolSize PPoolSizes;
    }
}