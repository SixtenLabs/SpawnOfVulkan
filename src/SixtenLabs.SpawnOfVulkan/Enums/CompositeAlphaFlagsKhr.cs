using System;

namespace SixtenLabs.SpawnOfVulkan
{
    [Flags()]
    public enum CompositeAlphaFlagsKhr : int
    {
        CompositeAlphaOpaqueBitKhr = 0x1,
        CompositeAlphaPreMultipliedBitKhr = 0x2,
        CompositeAlphaPostMultipliedBitKhr = 0x4,
        CompositeAlphaInheritBitKhr = 0x8
    }
}