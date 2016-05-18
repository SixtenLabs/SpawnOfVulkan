using System;

namespace SixtenLabs.SpawnOfVulkan
{
    unsafe internal struct PipelineColorBlendStateCreateInfo
    {
        internal StructureType sType;
        internal IntPtr pNext;
        internal uint flags;
        internal uint logicOpEnable;
        internal LogicOp logicOp;
        internal uint attachmentCount;
        internal PipelineColorBlendAttachmentState pAttachments;
        internal unsafe fixed float blendConstants[4];
    }
}