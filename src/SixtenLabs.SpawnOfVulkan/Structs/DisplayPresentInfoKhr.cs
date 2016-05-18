using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct DisplayPresentInfoKhr
    {
        internal StructureType sType;
        internal IntPtr pNext;
        internal Rect2D srcRect;
        internal Rect2D dstRect;
        internal uint persistent;
    }
}