using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct DeviceQueueCreateInfo
    {
        internal StructureType SType;
        internal IntPtr PNext;
        internal DeviceQueueCreateFlags Flags;
        internal uint QueueFamilyIndex;
        internal uint QueueCount;
        internal float PQueuePriorities;
    }
}