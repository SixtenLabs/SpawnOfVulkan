using System;
using System.Runtime.InteropServices;

namespace SixtenLabs.SpawnOfVulkan
{
    [StructLayout(LayoutKind.Explicit)]
    public struct CommandPoolHandle
    {
        [FieldOffset(0)]
        public IntPtr nativePointer;
        public readonly static CommandPoolHandle Null = new CommandPoolHandle(IntPtr.Zero);
        private CommandPoolHandle(IntPtr nativePointer)
        {
            this.nativePointer = nativePointer;
        }
    }
}