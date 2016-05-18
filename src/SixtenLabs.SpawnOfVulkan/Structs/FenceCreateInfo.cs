using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct FenceCreateInfo
    {
        internal StructureType sType;
        internal IntPtr pNext;
        internal FenceCreateFlags flags;
    }
}