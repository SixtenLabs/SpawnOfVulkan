using System;
using System.Runtime.InteropServices;

namespace SixtenLabs.SpawnOfVulkan
{
    [StructLayout(LayoutKind.Explicit)]
    public struct SemaphoreHandle
    {
        [FieldOffset(0)]
        public IntPtr nativePointer;
        public readonly static SemaphoreHandle Null = new SemaphoreHandle(IntPtr.Zero);
        private SemaphoreHandle(IntPtr nativePointer)
        {
            this.nativePointer = nativePointer;
        }
    }
}