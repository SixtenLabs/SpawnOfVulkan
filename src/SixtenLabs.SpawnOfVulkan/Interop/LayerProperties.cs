using System;

namespace SixtenLabs.SpawnOfVulkan
{
    unsafe internal struct LayerProperties
    {
        internal unsafe fixed char layerName[256];
        internal uint specVersion;
        internal uint implementationVersion;
        internal unsafe fixed char description[256];
    }
}