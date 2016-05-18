using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct PipelineVertexInputStateCreateInfo
    {
        internal StructureType sType;
        internal IntPtr pNext;
        internal uint flags;
        internal uint vertexBindingDescriptionCount;
        internal VertexInputBindingDescription pVertexBindingDescriptions;
        internal uint vertexAttributeDescriptionCount;
        internal VertexInputAttributeDescription pVertexAttributeDescriptions;
    }
}