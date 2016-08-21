using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct LayerProperties
    {
        internal unsafe fixed byte [256];
        internal uint SpecVersion;
        internal uint ImplementationVersion;
        internal unsafe fixed byte [256];
    }
}