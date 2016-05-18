using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct MappedMemoryRange
    {
        internal StructureType sType;
        internal IntPtr pNext;
        internal DeviceMemory memory;
        internal ulong offset;
        internal ulong size;
    }
}