using System;

namespace SixtenLabs.SpawnOfVulkan
{
    [Flags()]
    public enum BufferUsageFlags : int
    {
        /// <summary>
                /// Can be used as a source of transfer operations
                /// </summary>
        BufferUsageTransferSrcBit = 0x1,
        /// <summary>
                /// Can be used as a destination of transfer operations
                /// </summary>
        BufferUsageTransferDstBit = 0x2,
        /// <summary>
                /// Can be used as TBO
                /// </summary>
        BufferUsageUniformTexelBufferBit = 0x4,
        /// <summary>
                /// Can be used as IBO
                /// </summary>
        BufferUsageStorageTexelBufferBit = 0x8,
        /// <summary>
                /// Can be used as UBO
                /// </summary>
        BufferUsageUniformBufferBit = 0x10,
        /// <summary>
                /// Can be used as SSBO
                /// </summary>
        BufferUsageStorageBufferBit = 0x20,
        /// <summary>
                /// Can be used as source of fixed-function index fetch (index buffer)
                /// </summary>
        BufferUsageIndexBufferBit = 0x40,
        /// <summary>
                /// Can be used as source of fixed-function vertex fetch (VBO)
                /// </summary>
        BufferUsageVertexBufferBit = 0x80,
        /// <summary>
                /// Can be the source of indirect parameters (e.g. indirect buffer, parameter buffer)
                /// </summary>
        BufferUsageIndirectBufferBit = 0x100
    }
}