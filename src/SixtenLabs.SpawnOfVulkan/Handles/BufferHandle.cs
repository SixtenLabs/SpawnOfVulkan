using System;
using System.Runtime.InteropServices;

namespace SixtenLabs.SpawnOfVulkan
{
    [StructLayout(LayoutKind.Explicit)]
    public struct BufferHandle
    {
        [FieldOffset(0)]
        public IntPtr nativePointer;
        public readonly static BufferHandle Null = new BufferHandle(IntPtr.Zero);
        private BufferHandle(IntPtr @nativePointer)
        {
            this.nativePointer = nativePointer;
        }
    }
}