using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct PhysicalDeviceSparseProperties
    {
        internal uint residencyStandard2DBlockShape;
        internal uint residencyStandard2DMultisampleBlockShape;
        internal uint residencyStandard3DBlockShape;
        internal uint residencyAlignedMipSize;
        internal uint residencyNonResidentStrict;
    }
}