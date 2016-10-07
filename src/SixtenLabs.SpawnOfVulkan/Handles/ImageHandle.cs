using System;
using System.Runtime.InteropServices;

namespace SixtenLabs.SpawnOfVulkan
{
    [StructLayout(LayoutKind.Explicit)]
    public struct ImageHandle
    {
        [FieldOffset(0)]
        public IntPtr nativePointer;
        public readonly static ImageHandle Null = new ImageHandle(IntPtr.Zero);
        private ImageHandle(IntPtr nativePointer)
        {
            this.nativePointer = nativePointer;
        }
    }
}