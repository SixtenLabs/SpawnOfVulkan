using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct SubpassDescription
    {
        internal SubpassDescriptionFlags Flags;
        internal PipelineBindPoint PipelineBindPoint;
        internal uint InputAttachmentCount;
        internal AttachmentReference PInputAttachments;
        internal uint ColorAttachmentCount;
        internal AttachmentReference PColorAttachments;
        internal AttachmentReference PResolveAttachments;
        internal AttachmentReference PDepthStencilAttachment;
        internal uint PreserveAttachmentCount;
        internal uint PPreserveAttachments;
    }
}