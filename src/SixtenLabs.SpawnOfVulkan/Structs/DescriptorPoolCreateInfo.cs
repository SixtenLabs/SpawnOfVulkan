using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct DescriptorPoolCreateInfo
    {
        internal StructureType sType;
        internal IntPtr pNext;
        internal DescriptorPoolCreateFlags flags;
        internal uint maxSets;
        internal uint poolSizeCount;
        internal DescriptorPoolSize pPoolSizes;
    }
}