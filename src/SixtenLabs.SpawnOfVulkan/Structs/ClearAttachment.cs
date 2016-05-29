using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct ClearAttachment
    {
        internal ImageAspectFlags AspectMask;
        internal uint ColorAttachment;
        internal ClearValue ClearValue;
    }
}