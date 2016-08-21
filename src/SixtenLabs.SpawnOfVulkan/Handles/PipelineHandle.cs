using System;
using System.Runtime.InteropServices;

namespace SixtenLabs.SpawnOfVulkan
{
    [StructLayout(LayoutKind.Explicit)]
    public struct PipelineHandle
    {
        [FieldOffset(0)]
        public IntPtr nativePointer;
        public readonly static PipelineHandle Null = new PipelineHandle(IntPtr.Zero);
        private PipelineHandle(IntPtr @nativePointer)
        {
            this.nativePointer = nativePointer;
        }
    }
}