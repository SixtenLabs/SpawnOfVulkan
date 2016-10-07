using System;
using System.Runtime.InteropServices;

namespace SixtenLabs.SpawnOfVulkan
{
    [StructLayout(LayoutKind.Explicit)]
    public struct PipelineLayoutHandle
    {
        [FieldOffset(0)]
        public IntPtr nativePointer;
        public readonly static PipelineLayoutHandle Null = new PipelineLayoutHandle(IntPtr.Zero);
        private PipelineLayoutHandle(IntPtr nativePointer)
        {
            this.nativePointer = nativePointer;
        }
    }
}