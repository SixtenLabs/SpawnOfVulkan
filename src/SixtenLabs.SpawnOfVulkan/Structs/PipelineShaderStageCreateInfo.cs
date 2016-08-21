﻿using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct PipelineShaderStageCreateInfo
    {
        internal StructureType SType;
        internal IntPtr PNext;
        internal PipelineShaderStageCreateFlags Flags;
        internal ShaderStageFlags Stage;
        internal ShaderModuleHandle Module;
        internal byte PName;
        internal SpecializationInfo PSpecializationInfo;
    }
}