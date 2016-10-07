using System;
using System.Runtime.InteropServices;

namespace SixtenLabs.SpawnOfVulkan
{
    [StructLayout(LayoutKind.Explicit)]
    public struct CommandBufferHandle
    {
        [FieldOffset(0)]
        public IntPtr nativePointer;
        public readonly static CommandBufferHandle Null = new CommandBufferHandle(IntPtr.Zero);
        private CommandBufferHandle(IntPtr nativePointer)
        {
            this.nativePointer = nativePointer;
        }
    }
}