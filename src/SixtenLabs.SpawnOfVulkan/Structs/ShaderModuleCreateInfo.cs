using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct ShaderModuleCreateInfo
    {
        internal StructureType SType;
        internal IntPtr PNext;
        internal ShaderModuleCreateFlags Flags;
        internal UIntPtr CodeSize;
        internal uint PCode;
    }
}