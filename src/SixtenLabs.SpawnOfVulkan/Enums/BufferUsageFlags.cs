using System;

namespace SixtenLabs.SpawnOfVulkan
{
    [Flags]
    public enum BufferUsageFlags : int
    {
        BufferUsageTransferSrcBit = 0x1,
        BufferUsageTransferDstBit = 0x2,
        BufferUsageUniformTexelBufferBit = 0x4,
        BufferUsageStorageTexelBufferBit = 0x8,
        BufferUsageUniformBufferBit = 0x10,
        BufferUsageStorageBufferBit = 0x20,
        BufferUsageIndexBufferBit = 0x40,
        BufferUsageVertexBufferBit = 0x80,
        BufferUsageIndirectBufferBit = 0x100
    }
}