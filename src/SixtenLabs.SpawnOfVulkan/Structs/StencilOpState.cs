using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct StencilOpState
    {
        internal StencilOp FailOp;
        internal StencilOp PassOp;
        internal StencilOp DepthFailOp;
        internal CompareOp CompareOp;
        internal uint CompareMask;
        internal uint WriteMask;
        internal uint Reference;
    }
}