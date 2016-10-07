using System;

namespace SixtenLabs.SpawnOfVulkan
{
    [Flags()]
    public enum SparseMemoryBindFlags : int
    {
        /// <summary>
        /// Operation binds resource metadata to memory
        /// </summary>
        SparseMemoryBindMetadataBit = 0x1
    }
}