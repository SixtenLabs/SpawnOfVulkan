using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct RenderPassCreateInfo
    {
        internal StructureType SType;
        internal IntPtr PNext;
        internal RenderPassCreateFlags Flags;
        internal uint AttachmentCount;
        internal AttachmentDescription PAttachments;
        internal uint SubpassCount;
        internal SubpassDescription PSubpasses;
        internal uint DependencyCount;
        internal SubpassDependency PDependencies;
    }
}