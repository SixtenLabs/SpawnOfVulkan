using System;
using System.Runtime.InteropServices;

namespace SixtenLabs.SpawnOfVulkan
{
    [StructLayout(LayoutKind.Explicit)]
    public struct BufferViewHandle
    {
        [FieldOffset(0)]
        public IntPtr nativePointer;
        public readonly static BufferViewHandle Null = new BufferViewHandle(IntPtr.Zero);
        private BufferViewHandle(IntPtr @nativePointer)
        {
            this.nativePointer = nativePointer;
        }
    }
}