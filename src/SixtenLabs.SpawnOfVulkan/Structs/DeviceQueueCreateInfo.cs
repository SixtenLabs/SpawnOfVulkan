using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct DeviceQueueCreateInfo
    {
        internal StructureType sType;
        internal IntPtr pNext;
        internal uint flags;
        internal uint queueFamilyIndex;
        internal uint queueCount;
        internal float pQueuePriorities;
    }
}