using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct AttachmentDescription
    {
        internal AttachmentDescriptionFlags Flags;
        internal Format Format;
        internal SampleCountFlags Samples;
        internal AttachmentLoadOp LoadOp;
        internal AttachmentStoreOp StoreOp;
        internal AttachmentLoadOp StencilLoadOp;
        internal AttachmentStoreOp StencilStoreOp;
        internal ImageLayout InitialLayout;
        internal ImageLayout FinalLayout;
    }
}