using System;
using System.Runtime.InteropServices;

namespace SixtenLabs.SpawnOfVulkan
{
    [StructLayout(LayoutKind.Explicit)]
    public struct PipelineCacheHandle
    {
        [FieldOffset(0)]
        public IntPtr nativePointer;
        public readonly static PipelineCacheHandle Null = new PipelineCacheHandle(IntPtr.Zero);
        private PipelineCacheHandle(IntPtr nativePointer)
        {
            this.nativePointer = nativePointer;
        }
    }
}