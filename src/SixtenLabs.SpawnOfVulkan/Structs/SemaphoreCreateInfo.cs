using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct SemaphoreCreateInfo
    {
        internal StructureType sType;
        internal IntPtr pNext;
        internal uint flags;
    }
}