using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct WriteDescriptorSet
    {
        internal StructureType sType;
        internal IntPtr pNext;
        internal DescriptorSet dstSet;
        internal uint dstBinding;
        internal uint dstArrayElement;
        internal uint descriptorCount;
        internal DescriptorType descriptorType;
        internal DescriptorImageInfo pImageInfo;
        internal DescriptorBufferInfo pBufferInfo;
        internal BufferView pTexelBufferView;
    }
}