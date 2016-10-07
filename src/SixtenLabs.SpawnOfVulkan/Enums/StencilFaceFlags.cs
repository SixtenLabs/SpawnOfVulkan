using System;

namespace SixtenLabs.SpawnOfVulkan
{
    [Flags()]
    public enum StencilFaceFlags : int
    {
        /// <summary>
        /// Front face
        /// </summary>
        StencilFaceFrontBit = 0x1,
        /// <summary>
        /// Back face
        /// </summary>
        StencilFaceBackBit = 0x2,
        /// <summary>
        /// Front and back faces
        /// </summary>
        StencilFrontAndBack = 0x00000003
    }
}