using System;

namespace SixtenLabs.SpawnOfVulkan
{
    [Flags]
    public enum ColorComponentFlags : int
    {
        ColorComponentRBit = 0x1,
        ColorComponentGBit = 0x2,
        ColorComponentBBit = 0x4,
        ColorComponentABit = 0x8
    }
}