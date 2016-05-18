using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct CommandPoolCreateInfo
    {
        internal StructureType sType;
        internal IntPtr pNext;
        internal CommandPoolCreateFlags flags;
        internal uint queueFamilyIndex;
    }
}