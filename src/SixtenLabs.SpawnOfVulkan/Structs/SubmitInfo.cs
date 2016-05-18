using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct SubmitInfo
    {
        internal StructureType sType;
        internal IntPtr pNext;
        internal uint waitSemaphoreCount;
        internal Semaphore pWaitSemaphores;
        internal PipelineStageFlags pWaitDstStageMask;
        internal uint commandBufferCount;
        internal CommandBuffer pCommandBuffers;
        internal uint signalSemaphoreCount;
        internal Semaphore pSignalSemaphores;
    }
}