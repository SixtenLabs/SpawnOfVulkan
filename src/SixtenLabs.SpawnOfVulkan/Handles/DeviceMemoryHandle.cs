using System;
using System.Runtime.InteropServices;

namespace SixtenLabs.SpawnOfVulkan
{
    [StructLayout(LayoutKind.Explicit)]
    public struct DeviceMemoryHandle
    {
        [FieldOffset(0)]
        public IntPtr nativePointer;
        public readonly static DeviceMemoryHandle Null = new DeviceMemoryHandle(IntPtr.Zero);
        private DeviceMemoryHandle(IntPtr nativePointer)
        {
            this.nativePointer = nativePointer;
        }
    }
}