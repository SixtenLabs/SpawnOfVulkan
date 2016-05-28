using System;

namespace SixtenLabs.SpawnOfVulkan
{
    unsafe public struct PhysicalDeviceProperties
    {
        internal uint apiVersion;
        internal uint driverVersion;
        internal uint vendorID;
        internal uint deviceID;
        internal PhysicalDeviceType deviceType;
        internal string deviceName;
        internal unsafe fixed byte pipelineCacheUUID[16];
        internal PhysicalDeviceLimits limits;
        internal PhysicalDeviceSparseProperties sparseProperties;
    }
}