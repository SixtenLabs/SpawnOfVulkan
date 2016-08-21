using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct CopyDescriptorSet
    {
        internal StructureType SType;
        internal IntPtr PNext;
        internal DescriptorSetHandle SrcSet;
        internal uint SrcBinding;
        internal uint SrcArrayElement;
        internal DescriptorSetHandle DstSet;
        internal uint DstBinding;
        internal uint DstArrayElement;
        internal uint DescriptorCount;
    }
}