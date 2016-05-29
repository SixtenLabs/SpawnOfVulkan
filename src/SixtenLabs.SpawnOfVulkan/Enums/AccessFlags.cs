using System;

namespace SixtenLabs.SpawnOfVulkan
{
    [Flags]
    public enum AccessFlags : int
    {
        AccessIndirectCommandReadBit = 0x1,
        AccessIndexReadBit = 0x2,
        AccessVertexAttributeReadBit = 0x4,
        AccessUniformReadBit = 0x8,
        AccessInputAttachmentReadBit = 0x10,
        AccessShaderReadBit = 0x20,
        AccessShaderWriteBit = 0x40,
        AccessColorAttachmentReadBit = 0x80,
        AccessColorAttachmentWriteBit = 0x100,
        AccessDepthStencilAttachmentReadBit = 0x200,
        AccessDepthStencilAttachmentWriteBit = 0x400,
        AccessTransferReadBit = 0x800,
        AccessTransferWriteBit = 0x1000,
        AccessHostReadBit = 0x2000,
        AccessHostWriteBit = 0x4000,
        AccessMemoryReadBit = 0x8000,
        AccessMemoryWriteBit = 0x10000
    }
}