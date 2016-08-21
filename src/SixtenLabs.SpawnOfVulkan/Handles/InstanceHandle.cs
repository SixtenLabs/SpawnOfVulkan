using System;
using System.Runtime.InteropServices;

namespace SixtenLabs.SpawnOfVulkan
{
    [StructLayout(LayoutKind.Explicit)]
    public struct InstanceHandle
    {
        [FieldOffset(0)]
        public IntPtr nativePointer;
        public readonly static InstanceHandle Null = new InstanceHandle(IntPtr.Zero);
        private InstanceHandle(IntPtr @nativePointer)
        {
            this.nativePointer = nativePointer;
        }
    }
}