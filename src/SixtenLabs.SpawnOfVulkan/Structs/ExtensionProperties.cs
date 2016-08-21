using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct ExtensionProperties
    {
        internal unsafe fixed byte [256];
        internal uint SpecVersion;
    }
}