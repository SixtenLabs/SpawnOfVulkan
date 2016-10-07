using System.Runtime.InteropServices;

namespace SixtenLabs.SpawnOfVulkan
{
    [StructLayout(LayoutKind.Explicit)]
    public struct ClearValue
    {
        [FieldOffset(0)]
        internal ClearColorValue Color;
        [FieldOffset(0)]
        internal ClearDepthStencilValue DepthStencil;
    }
}