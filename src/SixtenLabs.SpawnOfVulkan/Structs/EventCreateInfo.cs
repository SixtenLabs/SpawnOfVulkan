using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct EventCreateInfo
    {
        internal StructureType SType;
        internal IntPtr PNext;
        internal EventCreateFlags Flags;
    }
}