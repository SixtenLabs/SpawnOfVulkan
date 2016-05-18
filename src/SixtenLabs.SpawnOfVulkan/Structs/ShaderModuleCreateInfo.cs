using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct ShaderModuleCreateInfo
    {
        internal StructureType sType;
        internal IntPtr pNext;
        internal uint flags;
        internal UIntPtr codeSize;
        internal uint pCode;
    }
}