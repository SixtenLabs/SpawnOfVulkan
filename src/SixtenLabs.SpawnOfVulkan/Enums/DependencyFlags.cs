using System;

namespace SixtenLabs.SpawnOfVulkan
{
    [Flags()]
    public enum DependencyFlags : int
    {
        /// <summary>
        /// Dependency is per pixel region 
        /// </summary>
        DependencyByRegionBit = 0x1
    }
}