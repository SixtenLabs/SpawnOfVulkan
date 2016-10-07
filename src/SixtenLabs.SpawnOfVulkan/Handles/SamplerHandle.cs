using System;
using System.Runtime.InteropServices;

namespace SixtenLabs.SpawnOfVulkan
{
    [StructLayout(LayoutKind.Explicit)]
    public struct SamplerHandle
    {
        [FieldOffset(0)]
        public IntPtr nativePointer;
        public readonly static SamplerHandle Null = new SamplerHandle(IntPtr.Zero);
        private SamplerHandle(IntPtr nativePointer)
        {
            this.nativePointer = nativePointer;
        }
    }
}