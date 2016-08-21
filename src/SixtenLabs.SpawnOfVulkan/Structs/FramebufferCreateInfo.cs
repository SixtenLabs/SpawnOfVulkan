using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct FramebufferCreateInfo
    {
        internal StructureType SType;
        internal IntPtr PNext;
        internal FramebufferCreateFlags Flags;
        internal RenderPassHandle RenderPass;
        internal uint AttachmentCount;
        internal ImageViewHandle PAttachments;
        internal uint Width;
        internal uint Height;
        internal uint Layers;
    }
}