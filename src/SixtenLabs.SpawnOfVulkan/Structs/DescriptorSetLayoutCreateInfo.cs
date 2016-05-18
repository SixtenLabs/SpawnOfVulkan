using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct DescriptorSetLayoutCreateInfo
    {
        internal StructureType sType;
        internal IntPtr pNext;
        internal uint flags;
        internal uint bindingCount;
        internal DescriptorSetLayoutBinding pBindings;
    }
}