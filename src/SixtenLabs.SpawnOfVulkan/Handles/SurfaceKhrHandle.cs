using System;
using System.Runtime.InteropServices;

namespace SixtenLabs.SpawnOfVulkan
{
    [StructLayout(LayoutKind.Explicit)]
    public struct SurfaceKhrHandle
    {
        [FieldOffset(0)]
        public IntPtr nativePointer;
        public readonly static SurfaceKhrHandle Null = new SurfaceKhrHandle(IntPtr.Zero);
        private SurfaceKhrHandle(IntPtr @nativePointer)
        {
            this.nativePointer = nativePointer;
        }
    }
}