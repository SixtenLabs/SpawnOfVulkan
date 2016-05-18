using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct CopyDescriptorSet
    {
        internal StructureType sType;
        internal IntPtr pNext;
        internal DescriptorSet srcSet;
        internal uint srcBinding;
        internal uint srcArrayElement;
        internal DescriptorSet dstSet;
        internal uint dstBinding;
        internal uint dstArrayElement;
        internal uint descriptorCount;
    }
}