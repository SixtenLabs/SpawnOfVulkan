using System;
using System.Runtime.InteropServices;

namespace SixtenLabs.SpawnOfVulkan
{
    [StructLayout(LayoutKind.Explicit)]
    public struct DescriptorPoolHandle
    {
        [FieldOffset(0)]
        public IntPtr nativePointer;
        public readonly static DescriptorPoolHandle Null = new DescriptorPoolHandle(IntPtr.Zero);
        private DescriptorPoolHandle(IntPtr nativePointer)
        {
            this.nativePointer = nativePointer;
        }
    }
}