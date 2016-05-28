using System;

namespace SixtenLabs.SpawnOfVulkan
{
    unsafe public struct LayerProperties
    {
        internal string layerName;
        internal uint specVersion;
        internal uint implementationVersion;
        internal string description;
    }
}