using System;

namespace SixtenLabs.SpawnOfVulkan
{
    unsafe internal struct PresentInfoKhr
    {
        internal StructureType sType;
        internal IntPtr pNext;
        internal uint waitSemaphoreCount;
        internal Semaphore pWaitSemaphores;
        internal uint swapchainCount;
        internal SwapchainKhr pSwapchains;
        internal uint pImageIndices;
        internal Result pResults;
    }
}