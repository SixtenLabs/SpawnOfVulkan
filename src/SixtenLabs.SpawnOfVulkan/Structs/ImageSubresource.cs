using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct ImageSubresource
    {
        internal ImageAspectFlags AspectMask;
        internal uint MipLevel;
        internal uint ArrayLayer;
    }
}