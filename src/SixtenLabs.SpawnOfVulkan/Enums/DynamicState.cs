﻿namespace SixtenLabs.SpawnOfVulkan
{
    public enum DynamicState : int
    {
        DynamicStateViewport = 0,
        DynamicStateScissor = 1,
        DynamicStateLineWidth = 2,
        DynamicStateDepthBias = 3,
        DynamicStateBlendConstants = 4,
        DynamicStateDepthBounds = 5,
        DynamicStateStencilCompareMask = 6,
        DynamicStateStencilWriteMask = 7,
        DynamicStateStencilReference = 8
    }
}