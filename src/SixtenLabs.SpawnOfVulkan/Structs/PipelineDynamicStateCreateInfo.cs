using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct PipelineDynamicStateCreateInfo
    {
        internal StructureType sType;
        internal IntPtr pNext;
        internal uint flags;
        internal uint dynamicStateCount;
        internal DynamicState pDynamicStates;
    }
}