using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct DescriptorBufferInfo
    {
        internal BufferHandle Buffer;
        internal ulong Offset;
        internal ulong Range;
    }
}