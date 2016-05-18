using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct DescriptorSetAllocateInfo
    {
        internal StructureType sType;
        internal IntPtr pNext;
        internal DescriptorPool descriptorPool;
        internal uint descriptorSetCount;
        internal DescriptorSetLayout pSetLayouts;
    }
}