using System.Runtime.InteropServices;

namespace SixtenLabs.SpawnOfVulkan
{
    [StructLayout(LayoutKind.Explicit)]
    public struct ClearColorValue
    {
        [FieldOffset(0)]
        internal unsafe fixed float Float32[4];
        [FieldOffset(0)]
        internal unsafe fixed int Int32[4];
        [FieldOffset(0)]
        internal unsafe fixed uint Uint32[4];
    }
}