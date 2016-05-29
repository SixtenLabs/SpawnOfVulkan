using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct SamplerCreateInfo
    {
        internal StructureType SType;
        internal IntPtr PNext;
        internal SamplerCreateFlags Flags;
        internal Filter MagFilter;
        internal Filter MinFilter;
        internal SamplerMipmapMode MipmapMode;
        internal SamplerAddressMode AddressModeU;
        internal SamplerAddressMode AddressModeV;
        internal SamplerAddressMode AddressModeW;
        internal float MipLodBias;
        internal uint AnisotropyEnable;
        internal float MaxAnisotropy;
        internal uint CompareEnable;
        internal CompareOp CompareOp;
        internal float MinLod;
        internal float MaxLod;
        internal BorderColor BorderColor;
        internal uint UnnormalizedCoordinates;
    }
}