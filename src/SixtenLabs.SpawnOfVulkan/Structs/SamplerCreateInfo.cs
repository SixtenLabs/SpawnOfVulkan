using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct SamplerCreateInfo
    {
        internal StructureType sType;
        internal IntPtr pNext;
        internal uint flags;
        internal Filter magFilter;
        internal Filter minFilter;
        internal SamplerMipmapMode mipmapMode;
        internal SamplerAddressMode addressModeU;
        internal SamplerAddressMode addressModeV;
        internal SamplerAddressMode addressModeW;
        internal float mipLodBias;
        internal uint anisotropyEnable;
        internal float maxAnisotropy;
        internal uint compareEnable;
        internal CompareOp compareOp;
        internal float minLod;
        internal float maxLod;
        internal BorderColor borderColor;
        internal uint unnormalizedCoordinates;
    }
}