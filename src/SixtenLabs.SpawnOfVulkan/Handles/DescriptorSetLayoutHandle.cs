using System;
using System.Runtime.InteropServices;

namespace SixtenLabs.SpawnOfVulkan
{
    [StructLayout(LayoutKind.Explicit)]
    public struct DescriptorSetLayoutHandle
    {
        [FieldOffset(0)]
        public IntPtr nativePointer;
        public readonly static DescriptorSetLayoutHandle Null = new DescriptorSetLayoutHandle(IntPtr.Zero);
        private DescriptorSetLayoutHandle(IntPtr nativePointer)
        {
            this.nativePointer = nativePointer;
        }
    }
}