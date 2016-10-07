using System;
using System.Runtime.InteropServices;

namespace SixtenLabs.SpawnOfVulkan
{
    [StructLayout(LayoutKind.Explicit)]
    public struct QueueHandle
    {
        [FieldOffset(0)]
        public IntPtr nativePointer;
        public readonly static QueueHandle Null = new QueueHandle(IntPtr.Zero);
        private QueueHandle(IntPtr nativePointer)
        {
            this.nativePointer = nativePointer;
        }
    }
}