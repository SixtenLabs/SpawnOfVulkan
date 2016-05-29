using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct DisplayModeCreateInfoKhr
    {
        internal StructureType SType;
        internal IntPtr PNext;
        internal DisplayModeCreateFlagsKhr Flags;
        internal DisplayModeParametersKhr Parameters;
    }
}