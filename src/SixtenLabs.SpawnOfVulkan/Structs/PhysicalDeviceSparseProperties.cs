using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct PhysicalDeviceSparseProperties
    {
        internal uint ResidencyStandard2DBlockShape;
        internal uint ResidencyStandard2DMultisampleBlockShape;
        internal uint ResidencyStandard3DBlockShape;
        internal uint ResidencyAlignedMipSize;
        internal uint ResidencyNonResidentStrict;
    }
}