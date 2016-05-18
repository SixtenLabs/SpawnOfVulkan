using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct BindSparseInfo
    {
        internal StructureType sType;
        internal IntPtr pNext;
        internal uint waitSemaphoreCount;
        internal Semaphore pWaitSemaphores;
        internal uint bufferBindCount;
        internal SparseBufferMemoryBindInfo pBufferBinds;
        internal uint imageOpaqueBindCount;
        internal SparseImageOpaqueMemoryBindInfo pImageOpaqueBinds;
        internal uint imageBindCount;
        internal SparseImageMemoryBindInfo pImageBinds;
        internal uint signalSemaphoreCount;
        internal Semaphore pSignalSemaphores;
    }
}