using System.Runtime.InteropServices;

namespace SixtenLabs.SpawnOfVulkan
{
    [StructLayout(LayoutKind.Explicit)]
    public struct ClearValue
    {
        [FieldOffset(0)]
        internal ClearColorValue color;
        [FieldOffset(0)]
        internal ClearDepthStencilValue depthStencil;
    }
}