using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct DisplayModeCreateInfoKhr
    {
        internal StructureType sType;
        internal IntPtr pNext;
        internal uint flags;
        internal DisplayModeParametersKhr parameters;
    }
}