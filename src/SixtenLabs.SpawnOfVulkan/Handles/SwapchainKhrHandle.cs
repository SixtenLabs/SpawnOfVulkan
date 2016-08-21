using System;
using System.Runtime.InteropServices;

namespace SixtenLabs.SpawnOfVulkan
{
    [StructLayout(LayoutKind.Explicit)]
    public struct SwapchainKhrHandle
    {
        [FieldOffset(0)]
        public IntPtr nativePointer;
        public readonly static SwapchainKhrHandle Null = new SwapchainKhrHandle(IntPtr.Zero);
        private SwapchainKhrHandle(IntPtr @nativePointer)
        {
            this.nativePointer = nativePointer;
        }
    }
}