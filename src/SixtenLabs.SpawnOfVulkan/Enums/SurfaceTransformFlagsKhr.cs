using System;

namespace SixtenLabs.SpawnOfVulkan
{
    [Flags]
    public enum SurfaceTransformFlagsKhr : int
    {
        SurfaceTransformIdentityBitKhr = 0x1,
        SurfaceTransformRotate90BitKhr = 0x2,
        SurfaceTransformRotate180BitKhr = 0x4,
        SurfaceTransformRotate270BitKhr = 0x8,
        SurfaceTransformHorizontalMirrorBitKhr = 0x10,
        SurfaceTransformHorizontalMirrorRotate90BitKhr = 0x20,
        SurfaceTransformHorizontalMirrorRotate180BitKhr = 0x40,
        SurfaceTransformHorizontalMirrorRotate270BitKhr = 0x80,
        SurfaceTransformInheritBitKhr = 0x100
    }
}