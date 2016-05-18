using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct PipelineTessellationStateCreateInfo
    {
        internal StructureType sType;
        internal IntPtr pNext;
        internal uint flags;
        internal uint patchControlPoints;
    }
}