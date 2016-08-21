using System;

namespace SixtenLabs.SpawnOfVulkan
{
    [Flags()]
    public enum ImageAspectFlags : int
    {
        ImageAspectColorBit = 0x1,
        ImageAspectDepthBit = 0x2,
        ImageAspectStencilBit = 0x4,
        ImageAspectMetadataBit = 0x8
    }
}