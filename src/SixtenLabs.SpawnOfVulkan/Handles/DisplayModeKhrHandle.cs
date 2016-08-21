using System;
using System.Runtime.InteropServices;

namespace SixtenLabs.SpawnOfVulkan
{
    [StructLayout(LayoutKind.Explicit)]
    public struct DisplayModeKhrHandle
    {
        [FieldOffset(0)]
        public IntPtr nativePointer;
        public readonly static DisplayModeKhrHandle Null = new DisplayModeKhrHandle(IntPtr.Zero);
        private DisplayModeKhrHandle(IntPtr @nativePointer)
        {
            this.nativePointer = nativePointer;
        }
    }
}