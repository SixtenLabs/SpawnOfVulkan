using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct PresentInfoKhr
    {
        internal StructureType SType;
        internal IntPtr PNext;
        internal uint WaitSemaphoreCount;
        internal SemaphoreHandle PWaitSemaphores;
        internal uint SwapchainCount;
        internal SwapchainKhrHandle PSwapchains;
        internal uint PImageIndices;
        internal Result PResults;
    }
}