using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct QueueFamilyProperties
    {
        internal QueueFlags QueueFlags;
        internal uint QueueCount;
        internal uint TimestampValidBits;
        internal Extent3D MinImageTransferGranularity;
    }
}