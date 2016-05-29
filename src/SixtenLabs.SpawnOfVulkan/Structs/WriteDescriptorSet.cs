using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct WriteDescriptorSet
    {
        internal StructureType SType;
        internal IntPtr PNext;
        internal DescriptorSet DstSet;
        internal uint DstBinding;
        internal uint DstArrayElement;
        internal uint DescriptorCount;
        internal DescriptorType DescriptorType;
        internal DescriptorImageInfo PImageInfo;
        internal DescriptorBufferInfo PBufferInfo;
        internal BufferView PTexelBufferView;
    }
}