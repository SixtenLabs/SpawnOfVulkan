using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct DeviceCreateInfo
    {
        internal StructureType SType;
        internal IntPtr PNext;
        internal DeviceCreateFlags Flags;
        internal uint QueueCreateInfoCount;
        internal DeviceQueueCreateInfo PQueueCreateInfos;
        internal uint EnabledLayerCount;
        internal byte PpEnabledLayerNames;
        internal uint EnabledExtensionCount;
        internal byte PpEnabledExtensionNames;
        internal PhysicalDeviceFeatures PEnabledFeatures;
    }
}