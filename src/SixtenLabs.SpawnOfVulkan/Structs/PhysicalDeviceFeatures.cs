using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct PhysicalDeviceFeatures
    {
        internal uint robustBufferAccess;
        internal uint fullDrawIndexUint32;
        internal uint imageCubeArray;
        internal uint independentBlend;
        internal uint geometryShader;
        internal uint tessellationShader;
        internal uint sampleRateShading;
        internal uint dualSrcBlend;
        internal uint logicOp;
        internal uint multiDrawIndirect;
        internal uint drawIndirectFirstInstance;
        internal uint depthClamp;
        internal uint depthBiasClamp;
        internal uint fillModeNonSolid;
        internal uint depthBounds;
        internal uint wideLines;
        internal uint largePoints;
        internal uint alphaToOne;
        internal uint multiViewport;
        internal uint samplerAnisotropy;
        internal uint textureCompressionETC2;
        internal uint TexturecompressionastcLdr;
        internal uint textureCompressionBC;
        internal uint occlusionQueryPrecise;
        internal uint pipelineStatisticsQuery;
        internal uint vertexPipelineStoresAndAtomics;
        internal uint fragmentStoresAndAtomics;
        internal uint shaderTessellationAndGeometryPointSize;
        internal uint shaderImageGatherExtended;
        internal uint shaderStorageImageExtendedFormats;
        internal uint shaderStorageImageMultisample;
        internal uint shaderStorageImageReadWithoutFormat;
        internal uint shaderStorageImageWriteWithoutFormat;
        internal uint shaderUniformBufferArrayDynamicIndexing;
        internal uint shaderSampledImageArrayDynamicIndexing;
        internal uint shaderStorageBufferArrayDynamicIndexing;
        internal uint shaderStorageImageArrayDynamicIndexing;
        internal uint shaderClipDistance;
        internal uint shaderCullDistance;
        internal uint shaderFloat64;
        internal uint shaderInt64;
        internal uint shaderInt16;
        internal uint shaderResourceResidency;
        internal uint shaderResourceMinLod;
        internal uint sparseBinding;
        internal uint sparseResidencyBuffer;
        internal uint sparseResidencyImage2D;
        internal uint sparseResidencyImage3D;
        internal uint sparseResidency2Samples;
        internal uint sparseResidency4Samples;
        internal uint sparseResidency8Samples;
        internal uint sparseResidency16Samples;
        internal uint sparseResidencyAliased;
        internal uint variableMultisampleRate;
        internal uint inheritedQueries;
    }
}