using System;
using System.Runtime.InteropServices;

namespace SixtenLabs.SpawnOfVulkan
{
    [StructLayout(LayoutKind.Explicit)]
    public struct DescriptorSetHandle
    {
        [FieldOffset(0)]
        public IntPtr nativePointer;
        public readonly static DescriptorSetHandle Null = new DescriptorSetHandle(IntPtr.Zero);
        private DescriptorSetHandle(IntPtr nativePointer)
        {
            this.nativePointer = nativePointer;
        }
    }
}