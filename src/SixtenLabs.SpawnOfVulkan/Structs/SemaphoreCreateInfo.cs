using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct SemaphoreCreateInfo
    {
        internal StructureType SType;
        internal IntPtr PNext;
        internal SemaphoreCreateFlags Flags;
    }
}