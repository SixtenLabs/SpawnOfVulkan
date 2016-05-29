using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct BindSparseInfo
    {
        internal StructureType SType;
        internal IntPtr PNext;
        internal uint WaitSemaphoreCount;
        internal Semaphore PWaitSemaphores;
        internal uint BufferBindCount;
        internal SparseBufferMemoryBindInfo PBufferBinds;
        internal uint ImageOpaqueBindCount;
        internal SparseImageOpaqueMemoryBindInfo PImageOpaqueBinds;
        internal uint ImageBindCount;
        internal SparseImageMemoryBindInfo PImageBinds;
        internal uint SignalSemaphoreCount;
        internal Semaphore PSignalSemaphores;
    }
}