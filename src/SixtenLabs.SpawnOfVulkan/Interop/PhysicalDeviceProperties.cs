using System;

namespace SixtenLabs.SpawnOfVulkan
{
    unsafe internal struct PhysicalDeviceProperties
    {
        internal uint apiVersion;
        internal uint driverVersion;
        internal uint vendorID;
        internal uint deviceID;
        internal PhysicalDeviceType deviceType;
        internal unsafe fixed char deviceName[256];
        internal unsafe fixed byte pipelineCacheUUID[16];
        internal PhysicalDeviceLimits limits;
        internal PhysicalDeviceSparseProperties sparseProperties;
    }
}