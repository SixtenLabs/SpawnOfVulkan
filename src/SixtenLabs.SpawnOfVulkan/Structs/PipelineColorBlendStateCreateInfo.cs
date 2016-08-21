using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct PipelineColorBlendStateCreateInfo
    {
        internal StructureType SType;
        internal IntPtr PNext;
        internal PipelineColorBlendStateCreateFlags Flags;
        internal uint LogicOpEnable;
        internal LogicOp LogicOp;
        internal uint AttachmentCount;
        internal PipelineColorBlendAttachmentState PAttachments;
        internal unsafe fixed float [4];
    }
}