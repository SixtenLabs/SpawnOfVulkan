using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct SubpassDescription
    {
        internal uint flags;
        internal PipelineBindPoint pipelineBindPoint;
        internal uint inputAttachmentCount;
        internal AttachmentReference pInputAttachments;
        internal uint colorAttachmentCount;
        internal AttachmentReference pColorAttachments;
        internal AttachmentReference pResolveAttachments;
        internal AttachmentReference pDepthStencilAttachment;
        internal uint preserveAttachmentCount;
        internal uint pPreserveAttachments;
    }
}