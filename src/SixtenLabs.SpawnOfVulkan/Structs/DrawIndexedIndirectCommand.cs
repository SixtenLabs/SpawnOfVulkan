using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct DrawIndexedIndirectCommand
    {
        internal uint indexCount;
        internal uint instanceCount;
        internal uint firstIndex;
        internal int vertexOffset;
        internal uint firstInstance;
    }
}