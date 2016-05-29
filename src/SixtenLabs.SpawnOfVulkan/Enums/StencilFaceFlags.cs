using System;

namespace SixtenLabs.SpawnOfVulkan
{
    [Flags]
    public enum StencilFaceFlags : int
    {
        StencilFaceFrontBit = 0x1,
        StencilFaceBackBit = 0x2,
        StencilFrontAndBack = 0x00000003
    }
}