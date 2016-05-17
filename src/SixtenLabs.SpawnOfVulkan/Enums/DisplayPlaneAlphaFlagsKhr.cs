using System;

namespace SixtenLabs.SpawnOfVulkan
{
    [Flags]
    public enum DisplayPlaneAlphaFlagsKhr : int
    {
        DisplayPlaneAlphaOpaqueBitKhr = 0x1,
        DisplayPlaneAlphaGlobalBitKhr = 0x2,
        DisplayPlaneAlphaPerPixelBitKhr = 0x4,
        DisplayPlaneAlphaPerPixelPremultipliedBitKhr = 0x8
    }
}