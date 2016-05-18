using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct RenderPassBeginInfo
    {
        internal StructureType sType;
        internal IntPtr pNext;
        internal RenderPass renderPass;
        internal Framebuffer framebuffer;
        internal Rect2D renderArea;
        internal uint clearValueCount;
        internal ClearValue pClearValues;
    }
}