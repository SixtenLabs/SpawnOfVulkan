using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct SubresourceLayout
    {
        internal ulong Offset;
        internal ulong Size;
        internal ulong RowPitch;
        internal ulong ArrayPitch;
        internal ulong DepthPitch;
    }
}