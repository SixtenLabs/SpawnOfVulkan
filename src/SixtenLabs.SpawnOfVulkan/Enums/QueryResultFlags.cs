using System;

namespace SixtenLabs.SpawnOfVulkan
{
    [Flags]
    public enum QueryResultFlags : int
    {
        QueryResult64Bit = 0x1,
        QueryResultWaitBit = 0x2,
        QueryResultWithAvailabilityBit = 0x4,
        QueryResultPartialBit = 0x8
    }
}