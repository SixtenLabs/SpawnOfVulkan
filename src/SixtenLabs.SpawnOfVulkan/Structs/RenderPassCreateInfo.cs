using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct RenderPassCreateInfo
    {
        internal StructureType sType;
        internal IntPtr pNext;
        internal uint flags;
        internal uint attachmentCount;
        internal AttachmentDescription pAttachments;
        internal uint subpassCount;
        internal SubpassDescription pSubpasses;
        internal uint dependencyCount;
        internal SubpassDependency pDependencies;
    }
}