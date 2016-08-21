using System;

namespace SixtenLabs.SpawnOfVulkan
{
    [Flags()]
    public enum FenceCreateFlags : int
    {
        FenceCreateSignaledBit = 0x1
    }
}