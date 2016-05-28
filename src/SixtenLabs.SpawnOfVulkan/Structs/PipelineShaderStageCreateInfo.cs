using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct PipelineShaderStageCreateInfo
    {
        internal StructureType sType;
        internal IntPtr pNext;
        internal uint flags;
        internal ShaderStageFlags stage;
        internal ShaderModule module;
        internal string pName;
        internal SpecializationInfo pSpecializationInfo;
    }
}