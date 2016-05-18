using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct SubresourceLayout
    {
        internal ulong offset;
        internal ulong size;
        internal ulong rowPitch;
        internal ulong arrayPitch;
        internal ulong depthPitch;
    }
}