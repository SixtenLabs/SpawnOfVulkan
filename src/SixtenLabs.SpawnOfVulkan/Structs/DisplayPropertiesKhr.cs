using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct DisplayPropertiesKhr
    {
        internal DisplayKhr display;
        internal string displayName;
        internal Extent2D physicalDimensions;
        internal Extent2D physicalResolution;
        internal SurfaceTransformFlagsKhr supportedTransforms;
        internal uint planeReorderPossible;
        internal uint persistentContent;
    }
}