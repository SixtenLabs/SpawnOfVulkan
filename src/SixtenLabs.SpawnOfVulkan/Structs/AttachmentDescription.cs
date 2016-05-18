using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct AttachmentDescription
    {
        internal AttachmentDescriptionFlags flags;
        internal Format format;
        internal SampleCountFlags samples;
        internal AttachmentLoadOp loadOp;
        internal AttachmentStoreOp storeOp;
        internal AttachmentLoadOp stencilLoadOp;
        internal AttachmentStoreOp stencilStoreOp;
        internal ImageLayout initialLayout;
        internal ImageLayout finalLayout;
    }
}