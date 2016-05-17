using System;

namespace SixtenLabs.SpawnOfVulkan
{
    [Flags]
    public enum SampleCountFlags : int
    {
        SampleCount1Bit = 0x1,
        SampleCount2Bit = 0x2,
        SampleCount4Bit = 0x4,
        SampleCount8Bit = 0x8,
        SampleCount16Bit = 0x10,
        SampleCount32Bit = 0x20,
        SampleCount64Bit = 0x40
    }
}