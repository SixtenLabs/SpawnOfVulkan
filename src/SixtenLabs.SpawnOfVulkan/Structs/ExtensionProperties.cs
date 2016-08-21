using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct ExtensionProperties
    {
        internal unsafe fixed byte extensionName[256];
        internal uint SpecVersion;
    }
}