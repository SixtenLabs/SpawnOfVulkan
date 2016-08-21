using System;

namespace SixtenLabs.SpawnOfVulkan
{
    [Flags()]
    public enum DescriptorPoolCreateFlags : int
    {
        /// <summary>
                /// Descriptor sets may be freed individually
                /// </summary>
        DescriptorPoolCreateFreeDescriptorSetBit = 0x1
    }
}