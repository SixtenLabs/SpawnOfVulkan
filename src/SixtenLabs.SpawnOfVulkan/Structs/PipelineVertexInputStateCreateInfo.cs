using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct PipelineVertexInputStateCreateInfo
    {
        internal StructureType SType;
        internal IntPtr PNext;
        internal PipelineVertexInputStateCreateFlags Flags;
        internal uint VertexBindingDescriptionCount;
        internal VertexInputBindingDescription PVertexBindingDescriptions;
        internal uint VertexAttributeDescriptionCount;
        internal VertexInputAttributeDescription PVertexAttributeDescriptions;
    }
}