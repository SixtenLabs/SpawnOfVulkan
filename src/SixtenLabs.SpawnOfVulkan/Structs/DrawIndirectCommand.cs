using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct DrawIndirectCommand
    {
        internal uint VertexCount;
        internal uint InstanceCount;
        internal uint FirstVertex;
        internal uint FirstInstance;
    }
}