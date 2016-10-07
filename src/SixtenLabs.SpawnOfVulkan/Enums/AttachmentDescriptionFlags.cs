using System;

namespace SixtenLabs.SpawnOfVulkan
{
    [Flags()]
    public enum AttachmentDescriptionFlags : int
    {
        /// <summary>
        /// The attachment may alias physical memory of another attachment in the same render pass
        /// </summary>
        AttachmentDescriptionMayAliasBit = 0x1
    }
}