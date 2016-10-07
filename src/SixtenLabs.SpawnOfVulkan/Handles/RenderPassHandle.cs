using System;
using System.Runtime.InteropServices;

namespace SixtenLabs.SpawnOfVulkan
{
    [StructLayout(LayoutKind.Explicit)]
    public struct RenderPassHandle
    {
        [FieldOffset(0)]
        public IntPtr nativePointer;
        public readonly static RenderPassHandle Null = new RenderPassHandle(IntPtr.Zero);
        private RenderPassHandle(IntPtr nativePointer)
        {
            this.nativePointer = nativePointer;
        }
    }
}