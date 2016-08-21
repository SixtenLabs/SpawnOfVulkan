using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct DescriptorSetAllocateInfo
    {
        internal StructureType SType;
        internal IntPtr PNext;
        internal DescriptorPoolHandle DescriptorPool;
        internal uint DescriptorSetCount;
        internal DescriptorSetLayoutHandle PSetLayouts;
    }
}