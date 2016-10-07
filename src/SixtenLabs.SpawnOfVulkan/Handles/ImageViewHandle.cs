using System;
using System.Runtime.InteropServices;

namespace SixtenLabs.SpawnOfVulkan
{
    [StructLayout(LayoutKind.Explicit)]
    public struct ImageViewHandle
    {
        [FieldOffset(0)]
        public IntPtr nativePointer;
        public readonly static ImageViewHandle Null = new ImageViewHandle(IntPtr.Zero);
        private ImageViewHandle(IntPtr nativePointer)
        {
            this.nativePointer = nativePointer;
        }
    }
}