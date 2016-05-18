using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct FramebufferCreateInfo
    {
        internal StructureType sType;
        internal IntPtr pNext;
        internal uint flags;
        internal RenderPass renderPass;
        internal uint attachmentCount;
        internal ImageView pAttachments;
        internal uint width;
        internal uint height;
        internal uint layers;
    }
}