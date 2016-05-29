using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct DrawIndexedIndirectCommand
    {
        internal uint IndexCount;
        internal uint InstanceCount;
        internal uint FirstIndex;
        internal int VertexOffset;
        internal uint FirstInstance;
    }
}