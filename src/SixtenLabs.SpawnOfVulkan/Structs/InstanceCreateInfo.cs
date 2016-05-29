using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct InstanceCreateInfo
    {
        internal StructureType SType;
        internal IntPtr PNext;
        internal InstanceCreateFlags Flags;
        internal ApplicationInfo PApplicationInfo;
        internal uint EnabledLayerCount;
        internal byte PpEnabledLayerNames;
        internal uint EnabledExtensionCount;
        internal byte PpEnabledExtensionNames;
    }
}