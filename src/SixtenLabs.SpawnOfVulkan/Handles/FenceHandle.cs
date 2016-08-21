using System;
using System.Runtime.InteropServices;

namespace SixtenLabs.SpawnOfVulkan
{
    [StructLayout(LayoutKind.Explicit)]
    public struct FenceHandle
    {
        [FieldOffset(0)]
        public IntPtr nativePointer;
        public readonly static FenceHandle Null = new FenceHandle(IntPtr.Zero);
        private FenceHandle(IntPtr @nativePointer)
        {
            this.nativePointer = nativePointer;
        }
    }
}