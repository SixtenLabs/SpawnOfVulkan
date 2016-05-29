using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct PipelineDynamicStateCreateInfo
    {
        internal StructureType SType;
        internal IntPtr PNext;
        internal PipelineDynamicStateCreateFlags Flags;
        internal uint DynamicStateCount;
        internal DynamicState PDynamicStates;
    }
}