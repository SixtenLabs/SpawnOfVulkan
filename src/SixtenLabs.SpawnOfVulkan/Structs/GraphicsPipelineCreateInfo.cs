using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct GraphicsPipelineCreateInfo
    {
        internal StructureType SType;
        internal IntPtr PNext;
        internal PipelineCreateFlags Flags;
        internal uint StageCount;
        internal PipelineShaderStageCreateInfo PStages;
        internal PipelineVertexInputStateCreateInfo PVertexInputState;
        internal PipelineInputAssemblyStateCreateInfo PInputAssemblyState;
        internal PipelineTessellationStateCreateInfo PTessellationState;
        internal PipelineViewportStateCreateInfo PViewportState;
        internal PipelineRasterizationStateCreateInfo PRasterizationState;
        internal PipelineMultisampleStateCreateInfo PMultisampleState;
        internal PipelineDepthStencilStateCreateInfo PDepthStencilState;
        internal PipelineColorBlendStateCreateInfo PColorBlendState;
        internal PipelineDynamicStateCreateInfo PDynamicState;
        internal PipelineLayout Layout;
        internal RenderPass RenderPass;
        internal uint Subpass;
        internal Pipeline BasePipelineHandle;
        internal int BasePipelineIndex;
    }
}