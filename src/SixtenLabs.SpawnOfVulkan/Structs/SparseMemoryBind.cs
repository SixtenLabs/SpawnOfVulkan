using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct SparseMemoryBind
    {
        internal ulong resourceOffset;
        internal ulong size;
        internal DeviceMemory memory;
        internal ulong memoryOffset;
        internal SparseMemoryBindFlags flags;
    }
}