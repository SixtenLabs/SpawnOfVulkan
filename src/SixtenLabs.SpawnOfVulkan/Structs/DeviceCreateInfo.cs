using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct DeviceCreateInfo
    {
        internal StructureType sType;
        internal IntPtr pNext;
        internal uint flags;
        internal uint queueCreateInfoCount;
        internal DeviceQueueCreateInfo pQueueCreateInfos;
        internal uint enabledLayerCount;
        internal string ppEnabledLayerNames;
        internal uint enabledExtensionCount;
        internal string ppEnabledExtensionNames;
        internal PhysicalDeviceFeatures pEnabledFeatures;
    }
}