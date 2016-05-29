using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct CommandPoolCreateInfo
    {
        internal StructureType SType;
        internal IntPtr PNext;
        internal CommandPoolCreateFlags Flags;
        internal uint QueueFamilyIndex;
    }
}