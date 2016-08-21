using System;
using System.Runtime.InteropServices;

namespace SixtenLabs.SpawnOfVulkan
{
    [StructLayout(LayoutKind.Explicit)]
    public struct PhysicalDeviceHandle
    {
        [FieldOffset(0)]
        public IntPtr nativePointer;
        public readonly static PhysicalDeviceHandle Null = new PhysicalDeviceHandle(IntPtr.Zero);
        private PhysicalDeviceHandle(IntPtr @nativePointer)
        {
            this.nativePointer = nativePointer;
        }
    }
}