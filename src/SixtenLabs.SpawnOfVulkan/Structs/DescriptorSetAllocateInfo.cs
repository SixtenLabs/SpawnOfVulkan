﻿using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct DescriptorSetAllocateInfo
    {
        internal StructureType SType;
        internal IntPtr PNext;
        internal DescriptorPool DescriptorPool;
        internal uint DescriptorSetCount;
        internal DescriptorSetLayout PSetLayouts;
    }
}