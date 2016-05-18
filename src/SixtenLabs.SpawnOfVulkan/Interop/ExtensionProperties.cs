using System;

namespace SixtenLabs.SpawnOfVulkan
{
    unsafe internal struct ExtensionProperties
    {
        internal unsafe fixed char extensionName[256];
        internal uint specVersion;
    }
}