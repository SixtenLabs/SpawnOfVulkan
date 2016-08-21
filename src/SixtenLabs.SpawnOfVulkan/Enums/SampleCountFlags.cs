using System;

namespace SixtenLabs.SpawnOfVulkan
{
    [Flags()]
    public enum SampleCountFlags : int
    {
        /// <summary>
                /// Sample count 1 supported
                /// </summary>
        SampleCount1Bit = 0x1,
        /// <summary>
                /// Sample count 2 supported
                /// </summary>
        SampleCount2Bit = 0x2,
        /// <summary>
                /// Sample count 4 supported
                /// </summary>
        SampleCount4Bit = 0x4,
        /// <summary>
                /// Sample count 8 supported
                /// </summary>
        SampleCount8Bit = 0x8,
        /// <summary>
                /// Sample count 16 supported
                /// </summary>
        SampleCount16Bit = 0x10,
        /// <summary>
                /// Sample count 32 supported
                /// </summary>
        SampleCount32Bit = 0x20,
        /// <summary>
                /// Sample count 64 supported
                /// </summary>
        SampleCount64Bit = 0x40
    }
}