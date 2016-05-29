using System;

namespace SixtenLabs.SpawnOfVulkan
{
    [Flags]
    public enum ImageUsageFlags : int
    {
        ImageUsageTransferSrcBit = 0x1,
        ImageUsageTransferDstBit = 0x2,
        ImageUsageSampledBit = 0x4,
        ImageUsageStorageBit = 0x8,
        ImageUsageColorAttachmentBit = 0x10,
        ImageUsageDepthStencilAttachmentBit = 0x20,
        ImageUsageTransientAttachmentBit = 0x40,
        ImageUsageInputAttachmentBit = 0x80
    }
}