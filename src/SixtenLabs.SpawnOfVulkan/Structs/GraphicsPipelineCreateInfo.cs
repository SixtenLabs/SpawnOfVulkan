using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct GraphicsPipelineCreateInfo
    {
        internal StructureType sType;
        internal IntPtr pNext;
        internal PipelineCreateFlags flags;
        internal uint stageCount;
        internal PipelineShaderStageCreateInfo pStages;
        internal PipelineVertexInputStateCreateInfo pVertexInputState;
        internal PipelineInputAssemblyStateCreateInfo pInputAssemblyState;
        internal PipelineTessellationStateCreateInfo pTessellationState;
        internal PipelineViewportStateCreateInfo pViewportState;
        internal PipelineRasterizationStateCreateInfo pRasterizationState;
        internal PipelineMultisampleStateCreateInfo pMultisampleState;
        internal PipelineDepthStencilStateCreateInfo pDepthStencilState;
        internal PipelineColorBlendStateCreateInfo pColorBlendState;
        internal PipelineDynamicStateCreateInfo pDynamicState;
        internal PipelineLayout layout;
        internal RenderPass renderPass;
        internal uint subpass;
        internal Pipeline basePipelineHandle;
        internal int basePipelineIndex;
    }
}