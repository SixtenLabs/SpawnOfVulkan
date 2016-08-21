using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct SparseMemoryBind
    {
        internal ulong ResourceOffset;
        internal ulong Size;
        internal DeviceMemoryHandle Memory;
        internal ulong MemoryOffset;
        internal SparseMemoryBindFlags Flags;
    }
}