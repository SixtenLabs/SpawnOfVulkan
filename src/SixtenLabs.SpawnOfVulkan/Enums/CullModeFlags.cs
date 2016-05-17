using System;

namespace SixtenLabs.SpawnOfVulkan
{
    [Flags]
    public enum CullModeFlags : int
    {
        CullModeNone = 0,
        CullModeFrontBit = 0x1,
        CullModeBackBit = 0x2,
        CullModeFrontAndBack = 0x00000003
    }
}