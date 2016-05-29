using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct DisplayPresentInfoKhr
    {
        internal StructureType SType;
        internal IntPtr PNext;
        internal Rect2D SrcRect;
        internal Rect2D DstRect;
        internal uint Persistent;
    }
}