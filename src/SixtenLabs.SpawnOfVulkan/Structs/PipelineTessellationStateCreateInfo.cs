using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct PipelineTessellationStateCreateInfo
    {
        internal StructureType SType;
        internal IntPtr PNext;
        internal PipelineTessellationStateCreateFlags Flags;
        internal uint PatchControlPoints;
    }
}