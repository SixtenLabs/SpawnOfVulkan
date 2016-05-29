using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct SubmitInfo
    {
        internal StructureType SType;
        internal IntPtr PNext;
        internal uint WaitSemaphoreCount;
        internal Semaphore PWaitSemaphores;
        internal PipelineStageFlags PWaitDstStageMask;
        internal uint CommandBufferCount;
        internal CommandBuffer PCommandBuffers;
        internal uint SignalSemaphoreCount;
        internal Semaphore PSignalSemaphores;
    }
}