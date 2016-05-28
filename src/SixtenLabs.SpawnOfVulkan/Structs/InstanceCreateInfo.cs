using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct InstanceCreateInfo
    {
        internal StructureType sType;
        internal IntPtr pNext;
        internal uint flags;
        internal ApplicationInfo pApplicationInfo;
        internal uint enabledLayerCount;
        internal string ppEnabledLayerNames;
        internal uint enabledExtensionCount;
        internal string ppEnabledExtensionNames;
    }
}