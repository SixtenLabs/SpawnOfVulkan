using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct BufferViewCreateInfo
    {
        internal StructureType SType;
        internal IntPtr PNext;
        internal BufferViewCreateFlags Flags;
        internal BufferHandle Buffer;
        internal Format Format;
        internal ulong Offset;
        internal ulong Range;
    }
}