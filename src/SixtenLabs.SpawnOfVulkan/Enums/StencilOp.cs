﻿namespace SixtenLabs.SpawnOfVulkan
{
    public enum StencilOp : int
    {
        StencilOpKeep = 0,
        StencilOpZero = 1,
        StencilOpReplace = 2,
        StencilOpIncrementAndClamp = 3,
        StencilOpDecrementAndClamp = 4,
        StencilOpInvert = 5,
        StencilOpIncrementAndWrap = 6,
        StencilOpDecrementAndWrap = 7
    }
}