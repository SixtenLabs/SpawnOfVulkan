using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct ClearAttachment
    {
        internal ImageAspectFlags aspectMask;
        internal uint colorAttachment;
        internal ClearValue clearValue;
    }
}