using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct PresentInfoKhr
    {
        internal StructureType SType;
        internal IntPtr PNext;
        internal uint WaitSemaphoreCount;
        internal Semaphore PWaitSemaphores;
        internal uint SwapchainCount;
        internal SwapchainKhr PSwapchains;
        internal uint PImageIndices;
        internal Result PResults;
    }
}