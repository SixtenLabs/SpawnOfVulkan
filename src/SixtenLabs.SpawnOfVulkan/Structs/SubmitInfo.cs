using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct SubmitInfo
    {
        internal StructureType SType;
        internal IntPtr PNext;
        internal uint WaitSemaphoreCount;
        internal SemaphoreHandle PWaitSemaphores;
        internal PipelineStageFlags PWaitDstStageMask;
        internal uint CommandBufferCount;
        internal CommandBufferHandle PCommandBuffers;
        internal uint SignalSemaphoreCount;
        internal SemaphoreHandle PSignalSemaphores;
    }
}