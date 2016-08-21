using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct RenderPassBeginInfo
    {
        internal StructureType SType;
        internal IntPtr PNext;
        internal RenderPassHandle RenderPass;
        internal FramebufferHandle Framebuffer;
        internal Rect2D RenderArea;
        internal uint ClearValueCount;
        internal ClearValue PClearValues;
    }
}