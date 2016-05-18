using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct StencilOpState
    {
        internal StencilOp failOp;
        internal StencilOp passOp;
        internal StencilOp depthFailOp;
        internal CompareOp compareOp;
        internal uint compareMask;
        internal uint writeMask;
        internal uint reference;
    }
}