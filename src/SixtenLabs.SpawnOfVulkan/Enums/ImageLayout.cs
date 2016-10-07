﻿namespace SixtenLabs.SpawnOfVulkan
{
    public enum ImageLayout : int
    {
        /// <summary>
        /// Implicit layout an image is when its contents are undefined due to various reasons (e.g. right after creation)
        /// </summary>
        ImageLayoutUndefined = 0,
        /// <summary>
        /// General layout when image can be used for any kind of access
        /// </summary>
        ImageLayoutGeneral = 1,
        /// <summary>
        /// Optimal layout when image is only used for color attachment read/write
        /// </summary>
        ImageLayoutColorAttachmentOptimal = 2,
        /// <summary>
        /// Optimal layout when image is only used for depth/stencil attachment read/write
        /// </summary>
        ImageLayoutDepthStencilAttachmentOptimal = 3,
        /// <summary>
        /// Optimal layout when image is used for read only depth/stencil attachment and shader access
        /// </summary>
        ImageLayoutDepthStencilReadOnlyOptimal = 4,
        /// <summary>
        /// Optimal layout when image is used for read only shader access
        /// </summary>
        ImageLayoutShaderReadOnlyOptimal = 5,
        /// <summary>
        /// Optimal layout when image is used only as source of transfer operations
        /// </summary>
        ImageLayoutTransferSrcOptimal = 6,
        /// <summary>
        /// Optimal layout when image is used only as destination of transfer operations
        /// </summary>
        ImageLayoutTransferDstOptimal = 7,
        /// <summary>
        /// Initial layout used when the data is populated by the CPU
        /// </summary>
        ImageLayoutPreinitialized = 8,
        ImageLayoutPresentSrcKhr = 1000001002
    }
}