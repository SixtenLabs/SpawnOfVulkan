using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct FramebufferCreateInfo
    {
        internal StructureType SType;
        internal IntPtr PNext;
        internal FramebufferCreateFlags Flags;
        internal RenderPass RenderPass;
        internal uint AttachmentCount;
        internal ImageView PAttachments;
        internal uint Width;
        internal uint Height;
        internal uint Layers;
    }
}