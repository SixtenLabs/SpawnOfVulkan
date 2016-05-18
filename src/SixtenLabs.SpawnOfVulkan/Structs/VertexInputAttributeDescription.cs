using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct VertexInputAttributeDescription
    {
        internal uint location;
        internal uint binding;
        internal Format format;
        internal uint offset;
    }
}