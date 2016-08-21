using System;

namespace SixtenLabs.SpawnOfVulkan
{
    [Flags()]
    public enum AccessFlags : int
    {
        /// <summary>
                /// Controls coherency of indirect command reads
                /// </summary>
        AccessIndirectCommandReadBit = 0x1,
        /// <summary>
                /// Controls coherency of index reads
                /// </summary>
        AccessIndexReadBit = 0x2,
        /// <summary>
                /// Controls coherency of vertex attribute reads
                /// </summary>
        AccessVertexAttributeReadBit = 0x4,
        /// <summary>
                /// Controls coherency of uniform buffer reads
                /// </summary>
        AccessUniformReadBit = 0x8,
        /// <summary>
                /// Controls coherency of input attachment reads
                /// </summary>
        AccessInputAttachmentReadBit = 0x10,
        /// <summary>
                /// Controls coherency of shader reads
                /// </summary>
        AccessShaderReadBit = 0x20,
        /// <summary>
                /// Controls coherency of shader writes
                /// </summary>
        AccessShaderWriteBit = 0x40,
        /// <summary>
                /// Controls coherency of color attachment reads
                /// </summary>
        AccessColorAttachmentReadBit = 0x80,
        /// <summary>
                /// Controls coherency of color attachment writes
                /// </summary>
        AccessColorAttachmentWriteBit = 0x100,
        /// <summary>
                /// Controls coherency of depth/stencil attachment reads
                /// </summary>
        AccessDepthStencilAttachmentReadBit = 0x200,
        /// <summary>
                /// Controls coherency of depth/stencil attachment writes
                /// </summary>
        AccessDepthStencilAttachmentWriteBit = 0x400,
        /// <summary>
                /// Controls coherency of transfer reads
                /// </summary>
        AccessTransferReadBit = 0x800,
        /// <summary>
                /// Controls coherency of transfer writes
                /// </summary>
        AccessTransferWriteBit = 0x1000,
        /// <summary>
                /// Controls coherency of host reads
                /// </summary>
        AccessHostReadBit = 0x2000,
        /// <summary>
                /// Controls coherency of host writes
                /// </summary>
        AccessHostWriteBit = 0x4000,
        /// <summary>
                /// Controls coherency of memory reads
                /// </summary>
        AccessMemoryReadBit = 0x8000,
        /// <summary>
                /// Controls coherency of memory writes
                /// </summary>
        AccessMemoryWriteBit = 0x10000
    }
}