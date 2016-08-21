using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct DisplayPropertiesKhr
    {
        internal DisplayKhrHandle Display;
        internal byte DisplayName;
        internal Extent2D PhysicalDimensions;
        internal Extent2D PhysicalResolution;
        internal SurfaceTransformFlagsKhr SupportedTransforms;
        internal uint PlaneReorderPossible;
        internal uint PersistentContent;
    }
}