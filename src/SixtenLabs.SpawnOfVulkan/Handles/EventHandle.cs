using System;
using System.Runtime.InteropServices;

namespace SixtenLabs.SpawnOfVulkan
{
    [StructLayout(LayoutKind.Explicit)]
    public struct EventHandle
    {
        [FieldOffset(0)]
        public IntPtr nativePointer;
        public readonly static EventHandle Null = new EventHandle(IntPtr.Zero);
        private EventHandle(IntPtr @nativePointer)
        {
            this.nativePointer = nativePointer;
        }
    }
}