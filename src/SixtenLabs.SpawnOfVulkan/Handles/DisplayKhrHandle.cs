using System;
using System.Runtime.InteropServices;

namespace SixtenLabs.SpawnOfVulkan
{
    [StructLayout(LayoutKind.Explicit)]
    public struct DisplayKhrHandle
    {
        [FieldOffset(0)]
        public IntPtr nativePointer;
        public readonly static DisplayKhrHandle Null = new DisplayKhrHandle(IntPtr.Zero);
        private DisplayKhrHandle(IntPtr nativePointer)
        {
            this.nativePointer = nativePointer;
        }
    }
}