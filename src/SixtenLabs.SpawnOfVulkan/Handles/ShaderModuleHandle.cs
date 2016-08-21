using System;
using System.Runtime.InteropServices;

namespace SixtenLabs.SpawnOfVulkan
{
    [StructLayout(LayoutKind.Explicit)]
    public struct ShaderModuleHandle
    {
        [FieldOffset(0)]
        public IntPtr nativePointer;
        public readonly static ShaderModuleHandle Null = new ShaderModuleHandle(IntPtr.Zero);
        private ShaderModuleHandle(IntPtr @nativePointer)
        {
            this.nativePointer = nativePointer;
        }
    }
}