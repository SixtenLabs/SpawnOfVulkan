using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct QueueFamilyProperties
    {
        internal QueueFlags queueFlags;
        internal uint queueCount;
        internal uint timestampValidBits;
        internal Extent3D minImageTransferGranularity;
    }
}