using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct MappedMemoryRange
    {
        internal StructureType SType;
        internal IntPtr PNext;
        internal DeviceMemory Memory;
        internal ulong Offset;
        internal ulong Size;
    }
}