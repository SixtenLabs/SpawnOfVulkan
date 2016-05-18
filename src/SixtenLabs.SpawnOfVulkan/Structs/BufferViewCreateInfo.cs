using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct BufferViewCreateInfo
    {
        internal StructureType sType;
        internal IntPtr pNext;
        internal uint flags;
        internal Buffer buffer;
        internal Format format;
        internal ulong offset;
        internal ulong range;
    }
}