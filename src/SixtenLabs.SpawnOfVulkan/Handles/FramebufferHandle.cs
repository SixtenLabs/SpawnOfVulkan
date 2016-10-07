using System;
using System.Runtime.InteropServices;

namespace SixtenLabs.SpawnOfVulkan
{
    [StructLayout(LayoutKind.Explicit)]
    public struct FramebufferHandle
    {
        [FieldOffset(0)]
        public IntPtr nativePointer;
        public readonly static FramebufferHandle Null = new FramebufferHandle(IntPtr.Zero);
        private FramebufferHandle(IntPtr nativePointer)
        {
            this.nativePointer = nativePointer;
        }
    }
}