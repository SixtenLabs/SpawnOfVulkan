using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct PhysicalDeviceFeatures
    {
        internal uint RobustBufferAccess;
        internal uint FullDrawIndexUint32;
        internal uint ImageCubeArray;
        internal uint IndependentBlend;
        internal uint GeometryShader;
        internal uint TessellationShader;
        internal uint SampleRateShading;
        internal uint DualSrcBlend;
        internal uint LogicOp;
        internal uint MultiDrawIndirect;
        internal uint DrawIndirectFirstInstance;
        internal uint DepthClamp;
        internal uint DepthBiasClamp;
        internal uint FillModeNonSolid;
        internal uint DepthBounds;
        internal uint WideLines;
        internal uint LargePoints;
        internal uint AlphaToOne;
        internal uint MultiViewport;
        internal uint SamplerAnisotropy;
        internal uint TextureCompressionETC2;
        internal uint TexturecompressionastcLdr;
        internal uint TextureCompressionBC;
        internal uint OcclusionQueryPrecise;
        internal uint PipelineStatisticsQuery;
        internal uint VertexPipelineStoresAndAtomics;
        internal uint FragmentStoresAndAtomics;
        internal uint ShaderTessellationAndGeometryPointSize;
        internal uint ShaderImageGatherExtended;
        internal uint ShaderStorageImageExtendedFormats;
        internal uint ShaderStorageImageMultisample;
        internal uint ShaderStorageImageReadWithoutFormat;
        internal uint ShaderStorageImageWriteWithoutFormat;
        internal uint ShaderUniformBufferArrayDynamicIndexing;
        internal uint ShaderSampledImageArrayDynamicIndexing;
        internal uint ShaderStorageBufferArrayDynamicIndexing;
        internal uint ShaderStorageImageArrayDynamicIndexing;
        internal uint ShaderClipDistance;
        internal uint ShaderCullDistance;
        internal uint ShaderFloat64;
        internal uint ShaderInt64;
        internal uint ShaderInt16;
        internal uint ShaderResourceResidency;
        internal uint ShaderResourceMinLod;
        internal uint SparseBinding;
        internal uint SparseResidencyBuffer;
        internal uint SparseResidencyImage2D;
        internal uint SparseResidencyImage3D;
        internal uint SparseResidency2Samples;
        internal uint SparseResidency4Samples;
        internal uint SparseResidency8Samples;
        internal uint SparseResidency16Samples;
        internal uint SparseResidencyAliased;
        internal uint VariableMultisampleRate;
        internal uint InheritedQueries;
    }
}