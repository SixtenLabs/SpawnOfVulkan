using System;
using System.Runtime.InteropServices;

namespace SixtenLabs.SpawnOfVulkan
{
    [StructLayout(LayoutKind.Explicit)]
    public struct QueryPoolHandle
    {
        [FieldOffset(0)]
        public IntPtr nativePointer;
        public readonly static QueryPoolHandle Null = new QueryPoolHandle(IntPtr.Zero);
        private QueryPoolHandle(IntPtr nativePointer)
        {
            this.nativePointer = nativePointer;
        }
    }
}