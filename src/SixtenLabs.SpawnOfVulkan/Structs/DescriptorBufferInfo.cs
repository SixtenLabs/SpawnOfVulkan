using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct DescriptorBufferInfo
    {
        internal Buffer buffer;
        internal ulong offset;
        internal ulong range;
    }
}