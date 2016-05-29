using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct FenceCreateInfo
    {
        internal StructureType SType;
        internal IntPtr PNext;
        internal FenceCreateFlags Flags;
    }
}