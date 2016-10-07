using System;
using System.Runtime.InteropServices;

namespace SixtenLabs.SpawnOfVulkan
{
    [StructLayout(LayoutKind.Explicit)]
    public struct DebugReportCallbackExtHandle
    {
        [FieldOffset(0)]
        public IntPtr nativePointer;
        public readonly static DebugReportCallbackExtHandle Null = new DebugReportCallbackExtHandle(IntPtr.Zero);
        private DebugReportCallbackExtHandle(IntPtr nativePointer)
        {
            this.nativePointer = nativePointer;
        }
    }
}