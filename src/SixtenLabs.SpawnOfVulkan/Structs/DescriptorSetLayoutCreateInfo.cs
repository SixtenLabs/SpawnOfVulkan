using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct DescriptorSetLayoutCreateInfo
    {
        internal StructureType SType;
        internal IntPtr PNext;
        internal DescriptorSetLayoutCreateFlags Flags;
        internal uint BindingCount;
        internal DescriptorSetLayoutBinding PBindings;
    }
}