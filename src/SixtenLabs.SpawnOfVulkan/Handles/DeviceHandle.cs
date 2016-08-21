using System;
using System.Runtime.InteropServices;

namespace SixtenLabs.SpawnOfVulkan
{
    [StructLayout(LayoutKind.Explicit)]
    public struct DeviceHandle
    {
        [FieldOffset(0)]
        public IntPtr nativePointer;
        public readonly static DeviceHandle Null = new DeviceHandle(IntPtr.Zero);
        private DeviceHandle(IntPtr @nativePointer)
        {
            this.nativePointer = nativePointer;
        }
    }
}