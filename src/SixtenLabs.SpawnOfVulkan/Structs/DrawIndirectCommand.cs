using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct DrawIndirectCommand
    {
        internal uint vertexCount;
        internal uint instanceCount;
        internal uint firstVertex;
        internal uint firstInstance;
    }
}