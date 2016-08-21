using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct PhysicalDeviceProperties
    {
        internal uint ApiVersion;
        internal uint DriverVersion;
        internal uint VendorID;
        internal uint DeviceID;
        internal PhysicalDeviceType DeviceType;
        internal unsafe fixed byte [256];
        internal unsafe fixed byte [16];
        internal PhysicalDeviceLimits Limits;
        internal PhysicalDeviceSparseProperties SparseProperties;
    }
}