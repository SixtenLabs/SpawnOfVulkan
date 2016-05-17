using System;

namespace SixtenLabs.SpawnOfVulkan
{
    [Flags]
    public enum DescriptorPoolCreateFlags : int
    {
        DescriptorPoolCreateFreeDescriptorSetBit = 0x1
    }
}