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
        internal char ppEnabledLayerNames;
        internal uint enabledExtensionCount;
        internal char ppEnabledExtensionNames;
        internal PhysicalDeviceFeatures pEnabledFeatures;
    }
}