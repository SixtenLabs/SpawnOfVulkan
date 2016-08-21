using System;
using System.Runtime.InteropServices;

namespace SixtenLabs.SpawnOfVulkan
{
    public static partial class Vk
    {
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateInstanceDelegate(InstanceCreateInfo @pCreateInfo, AllocationCallbacks @pAllocator, InstanceHandle @pInstance);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr DestroyInstanceDelegate(InstanceHandle @instance, AllocationCallbacks @pAllocator);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result EnumeratePhysicalDevicesDelegate(InstanceHandle @instance, uint @pPhysicalDeviceCount, PhysicalDeviceHandle @pPhysicalDevices);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr GetDeviceProcAddrDelegate(DeviceHandle @device, byte @pName);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr GetInstanceProcAddrDelegate(InstanceHandle @instance, byte @pName);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr GetPhysicalDevicePropertiesDelegate(PhysicalDeviceHandle @physicalDevice, PhysicalDeviceProperties @pProperties);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr GetPhysicalDeviceQueueFamilyPropertiesDelegate(PhysicalDeviceHandle @physicalDevice, uint @pQueueFamilyPropertyCount, QueueFamilyProperties @pQueueFamilyProperties);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr GetPhysicalDeviceMemoryPropertiesDelegate(PhysicalDeviceHandle @physicalDevice, PhysicalDeviceMemoryProperties @pMemoryProperties);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr GetPhysicalDeviceFeaturesDelegate(PhysicalDeviceHandle @physicalDevice, PhysicalDeviceFeatures @pFeatures);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr GetPhysicalDeviceFormatPropertiesDelegate(PhysicalDeviceHandle @physicalDevice, Format @format, FormatProperties @pFormatProperties);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result GetPhysicalDeviceImageFormatPropertiesDelegate(PhysicalDeviceHandle @physicalDevice, Format @format, ImageType @type, ImageTiling @tiling, ImageUsageFlags @usage, ImageCreateFlags @flags, ImageFormatProperties @pImageFormatProperties);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateDeviceDelegate(PhysicalDeviceHandle @physicalDevice, DeviceCreateInfo @pCreateInfo, AllocationCallbacks @pAllocator, DeviceHandle @pDevice);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr DestroyDeviceDelegate(DeviceHandle @device, AllocationCallbacks @pAllocator);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result EnumerateInstanceLayerPropertiesDelegate(uint @pPropertyCount, LayerProperties @pProperties);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result EnumerateInstanceExtensionPropertiesDelegate(byte @pLayerName, uint @pPropertyCount, ExtensionProperties @pProperties);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result EnumerateDeviceLayerPropertiesDelegate(PhysicalDeviceHandle @physicalDevice, uint @pPropertyCount, LayerProperties @pProperties);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result EnumerateDeviceExtensionPropertiesDelegate(PhysicalDeviceHandle @physicalDevice, byte @pLayerName, uint @pPropertyCount, ExtensionProperties @pProperties);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr GetDeviceQueueDelegate(DeviceHandle @device, uint @queueFamilyIndex, uint @queueIndex, QueueHandle @pQueue);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result QueueSubmitDelegate(QueueHandle @queue, uint @submitCount, SubmitInfo @pSubmits, FenceHandle @fence);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result QueueWaitIdleDelegate(QueueHandle @queue);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result DeviceWaitIdleDelegate(DeviceHandle @device);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result AllocateMemoryDelegate(DeviceHandle @device, MemoryAllocateInfo @pAllocateInfo, AllocationCallbacks @pAllocator, DeviceMemoryHandle @pMemory);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr FreeMemoryDelegate(DeviceHandle @device, DeviceMemoryHandle @memory, AllocationCallbacks @pAllocator);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result MapMemoryDelegate(DeviceHandle @device, DeviceMemoryHandle @memory, ulong @offset, ulong @size, MemoryMapFlags @flags, IntPtr @ppData);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr UnmapMemoryDelegate(DeviceHandle @device, DeviceMemoryHandle @memory);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result FlushMappedMemoryRangesDelegate(DeviceHandle @device, uint @memoryRangeCount, MappedMemoryRange @pMemoryRanges);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result InvalidateMappedMemoryRangesDelegate(DeviceHandle @device, uint @memoryRangeCount, MappedMemoryRange @pMemoryRanges);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr GetDeviceMemoryCommitmentDelegate(DeviceHandle @device, DeviceMemoryHandle @memory, ulong @pCommittedMemoryInBytes);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr GetBufferMemoryRequirementsDelegate(DeviceHandle @device, BufferHandle @buffer, MemoryRequirements @pMemoryRequirements);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result BindBufferMemoryDelegate(DeviceHandle @device, BufferHandle @buffer, DeviceMemoryHandle @memory, ulong @memoryOffset);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr GetImageMemoryRequirementsDelegate(DeviceHandle @device, ImageHandle @image, MemoryRequirements @pMemoryRequirements);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result BindImageMemoryDelegate(DeviceHandle @device, ImageHandle @image, DeviceMemoryHandle @memory, ulong @memoryOffset);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr GetImageSparseMemoryRequirementsDelegate(DeviceHandle @device, ImageHandle @image, uint @pSparseMemoryRequirementCount, SparseImageMemoryRequirements @pSparseMemoryRequirements);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr GetPhysicalDeviceSparseImageFormatPropertiesDelegate(PhysicalDeviceHandle @physicalDevice, Format @format, ImageType @type, SampleCountFlags @samples, ImageUsageFlags @usage, ImageTiling @tiling, uint @pPropertyCount, SparseImageFormatProperties @pProperties);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result QueueBindSparseDelegate(QueueHandle @queue, uint @bindInfoCount, BindSparseInfo @pBindInfo, FenceHandle @fence);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateFenceDelegate(DeviceHandle @device, FenceCreateInfo @pCreateInfo, AllocationCallbacks @pAllocator, FenceHandle @pFence);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr DestroyFenceDelegate(DeviceHandle @device, FenceHandle @fence, AllocationCallbacks @pAllocator);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result ResetFencesDelegate(DeviceHandle @device, uint @fenceCount, FenceHandle @pFences);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result GetFenceStatusDelegate(DeviceHandle @device, FenceHandle @fence);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result WaitForFencesDelegate(DeviceHandle @device, uint @fenceCount, FenceHandle @pFences, uint @waitAll, ulong @timeout);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateSemaphoreDelegate(DeviceHandle @device, SemaphoreCreateInfo @pCreateInfo, AllocationCallbacks @pAllocator, SemaphoreHandle @pSemaphore);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr DestroySemaphoreDelegate(DeviceHandle @device, SemaphoreHandle @semaphore, AllocationCallbacks @pAllocator);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateEventDelegate(DeviceHandle @device, EventCreateInfo @pCreateInfo, AllocationCallbacks @pAllocator, EventHandle @pEvent);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr DestroyEventDelegate(DeviceHandle @device, EventHandle @event, AllocationCallbacks @pAllocator);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result GetEventStatusDelegate(DeviceHandle @device, EventHandle @event);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result SetEventDelegate(DeviceHandle @device, EventHandle @event);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result ResetEventDelegate(DeviceHandle @device, EventHandle @event);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateQueryPoolDelegate(DeviceHandle @device, QueryPoolCreateInfo @pCreateInfo, AllocationCallbacks @pAllocator, QueryPoolHandle @pQueryPool);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr DestroyQueryPoolDelegate(DeviceHandle @device, QueryPoolHandle @queryPool, AllocationCallbacks @pAllocator);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result GetQueryPoolResultsDelegate(DeviceHandle @device, QueryPoolHandle @queryPool, uint @firstQuery, uint @queryCount, UIntPtr @dataSize, IntPtr @pData, ulong @stride, QueryResultFlags @flags);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateBufferDelegate(DeviceHandle @device, BufferCreateInfo @pCreateInfo, AllocationCallbacks @pAllocator, BufferHandle @pBuffer);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr DestroyBufferDelegate(DeviceHandle @device, BufferHandle @buffer, AllocationCallbacks @pAllocator);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateBufferViewDelegate(DeviceHandle @device, BufferViewCreateInfo @pCreateInfo, AllocationCallbacks @pAllocator, BufferViewHandle @pView);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr DestroyBufferViewDelegate(DeviceHandle @device, BufferViewHandle @bufferView, AllocationCallbacks @pAllocator);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateImageDelegate(DeviceHandle @device, ImageCreateInfo @pCreateInfo, AllocationCallbacks @pAllocator, ImageHandle @pImage);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr DestroyImageDelegate(DeviceHandle @device, ImageHandle @image, AllocationCallbacks @pAllocator);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr GetImageSubresourceLayoutDelegate(DeviceHandle @device, ImageHandle @image, ImageSubresource @pSubresource, SubresourceLayout @pLayout);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateImageViewDelegate(DeviceHandle @device, ImageViewCreateInfo @pCreateInfo, AllocationCallbacks @pAllocator, ImageViewHandle @pView);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr DestroyImageViewDelegate(DeviceHandle @device, ImageViewHandle @imageView, AllocationCallbacks @pAllocator);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateShaderModuleDelegate(DeviceHandle @device, ShaderModuleCreateInfo @pCreateInfo, AllocationCallbacks @pAllocator, ShaderModuleHandle @pShaderModule);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr DestroyShaderModuleDelegate(DeviceHandle @device, ShaderModuleHandle @shaderModule, AllocationCallbacks @pAllocator);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreatePipelineCacheDelegate(DeviceHandle @device, PipelineCacheCreateInfo @pCreateInfo, AllocationCallbacks @pAllocator, PipelineCacheHandle @pPipelineCache);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr DestroyPipelineCacheDelegate(DeviceHandle @device, PipelineCacheHandle @pipelineCache, AllocationCallbacks @pAllocator);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result GetPipelineCacheDataDelegate(DeviceHandle @device, PipelineCacheHandle @pipelineCache, UIntPtr @pDataSize, IntPtr @pData);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result MergePipelineCachesDelegate(DeviceHandle @device, PipelineCacheHandle @dstCache, uint @srcCacheCount, PipelineCacheHandle @pSrcCaches);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateGraphicsPipelinesDelegate(DeviceHandle @device, PipelineCacheHandle @pipelineCache, uint @createInfoCount, GraphicsPipelineCreateInfo @pCreateInfos, AllocationCallbacks @pAllocator, PipelineHandle @pPipelines);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateComputePipelinesDelegate(DeviceHandle @device, PipelineCacheHandle @pipelineCache, uint @createInfoCount, ComputePipelineCreateInfo @pCreateInfos, AllocationCallbacks @pAllocator, PipelineHandle @pPipelines);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr DestroyPipelineDelegate(DeviceHandle @device, PipelineHandle @pipeline, AllocationCallbacks @pAllocator);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreatePipelineLayoutDelegate(DeviceHandle @device, PipelineLayoutCreateInfo @pCreateInfo, AllocationCallbacks @pAllocator, PipelineLayoutHandle @pPipelineLayout);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr DestroyPipelineLayoutDelegate(DeviceHandle @device, PipelineLayoutHandle @pipelineLayout, AllocationCallbacks @pAllocator);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateSamplerDelegate(DeviceHandle @device, SamplerCreateInfo @pCreateInfo, AllocationCallbacks @pAllocator, SamplerHandle @pSampler);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr DestroySamplerDelegate(DeviceHandle @device, SamplerHandle @sampler, AllocationCallbacks @pAllocator);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateDescriptorSetLayoutDelegate(DeviceHandle @device, DescriptorSetLayoutCreateInfo @pCreateInfo, AllocationCallbacks @pAllocator, DescriptorSetLayoutHandle @pSetLayout);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr DestroyDescriptorSetLayoutDelegate(DeviceHandle @device, DescriptorSetLayoutHandle @descriptorSetLayout, AllocationCallbacks @pAllocator);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateDescriptorPoolDelegate(DeviceHandle @device, DescriptorPoolCreateInfo @pCreateInfo, AllocationCallbacks @pAllocator, DescriptorPoolHandle @pDescriptorPool);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr DestroyDescriptorPoolDelegate(DeviceHandle @device, DescriptorPoolHandle @descriptorPool, AllocationCallbacks @pAllocator);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result ResetDescriptorPoolDelegate(DeviceHandle @device, DescriptorPoolHandle @descriptorPool, DescriptorPoolResetFlags @flags);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result AllocateDescriptorSetsDelegate(DeviceHandle @device, DescriptorSetAllocateInfo @pAllocateInfo, DescriptorSetHandle @pDescriptorSets);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result FreeDescriptorSetsDelegate(DeviceHandle @device, DescriptorPoolHandle @descriptorPool, uint @descriptorSetCount, DescriptorSetHandle @pDescriptorSets);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr UpdateDescriptorSetsDelegate(DeviceHandle @device, uint @descriptorWriteCount, WriteDescriptorSet @pDescriptorWrites, uint @descriptorCopyCount, CopyDescriptorSet @pDescriptorCopies);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateFramebufferDelegate(DeviceHandle @device, FramebufferCreateInfo @pCreateInfo, AllocationCallbacks @pAllocator, FramebufferHandle @pFramebuffer);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr DestroyFramebufferDelegate(DeviceHandle @device, FramebufferHandle @framebuffer, AllocationCallbacks @pAllocator);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateRenderPassDelegate(DeviceHandle @device, RenderPassCreateInfo @pCreateInfo, AllocationCallbacks @pAllocator, RenderPassHandle @pRenderPass);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr DestroyRenderPassDelegate(DeviceHandle @device, RenderPassHandle @renderPass, AllocationCallbacks @pAllocator);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr GetRenderAreaGranularityDelegate(DeviceHandle @device, RenderPassHandle @renderPass, Extent2D @pGranularity);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateCommandPoolDelegate(DeviceHandle @device, CommandPoolCreateInfo @pCreateInfo, AllocationCallbacks @pAllocator, CommandPoolHandle @pCommandPool);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr DestroyCommandPoolDelegate(DeviceHandle @device, CommandPoolHandle @commandPool, AllocationCallbacks @pAllocator);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result ResetCommandPoolDelegate(DeviceHandle @device, CommandPoolHandle @commandPool, CommandPoolResetFlags @flags);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result AllocateCommandBuffersDelegate(DeviceHandle @device, CommandBufferAllocateInfo @pAllocateInfo, CommandBufferHandle @pCommandBuffers);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr FreeCommandBuffersDelegate(DeviceHandle @device, CommandPoolHandle @commandPool, uint @commandBufferCount, CommandBufferHandle @pCommandBuffers);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result BeginCommandBufferDelegate(CommandBufferHandle @commandBuffer, CommandBufferBeginInfo @pBeginInfo);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result EndCommandBufferDelegate(CommandBufferHandle @commandBuffer);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result ResetCommandBufferDelegate(CommandBufferHandle @commandBuffer, CommandBufferResetFlags @flags);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdBindPipelineDelegate(CommandBufferHandle @commandBuffer, PipelineBindPoint @pipelineBindPoint, PipelineHandle @pipeline);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdSetViewportDelegate(CommandBufferHandle @commandBuffer, uint @firstViewport, uint @viewportCount, Viewport @pViewports);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdSetScissorDelegate(CommandBufferHandle @commandBuffer, uint @firstScissor, uint @scissorCount, Rect2D @pScissors);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdSetLineWidthDelegate(CommandBufferHandle @commandBuffer, float @lineWidth);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdSetDepthBiasDelegate(CommandBufferHandle @commandBuffer, float @depthBiasConstantFactor, float @depthBiasClamp, float @depthBiasSlopeFactor);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdSetBlendConstantsDelegate(CommandBufferHandle @commandBuffer, float @blendConstants);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdSetDepthBoundsDelegate(CommandBufferHandle @commandBuffer, float @minDepthBounds, float @maxDepthBounds);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdSetStencilCompareMaskDelegate(CommandBufferHandle @commandBuffer, StencilFaceFlags @faceMask, uint @compareMask);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdSetStencilWriteMaskDelegate(CommandBufferHandle @commandBuffer, StencilFaceFlags @faceMask, uint @writeMask);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdSetStencilReferenceDelegate(CommandBufferHandle @commandBuffer, StencilFaceFlags @faceMask, uint @reference);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdBindDescriptorSetsDelegate(CommandBufferHandle @commandBuffer, PipelineBindPoint @pipelineBindPoint, PipelineLayoutHandle @layout, uint @firstSet, uint @descriptorSetCount, DescriptorSetHandle @pDescriptorSets, uint @dynamicOffsetCount, uint @pDynamicOffsets);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdBindIndexBufferDelegate(CommandBufferHandle @commandBuffer, BufferHandle @buffer, ulong @offset, IndexType @indexType);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdBindVertexBuffersDelegate(CommandBufferHandle @commandBuffer, uint @firstBinding, uint @bindingCount, BufferHandle @pBuffers, ulong @pOffsets);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdDrawDelegate(CommandBufferHandle @commandBuffer, uint @vertexCount, uint @instanceCount, uint @firstVertex, uint @firstInstance);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdDrawIndexedDelegate(CommandBufferHandle @commandBuffer, uint @indexCount, uint @instanceCount, uint @firstIndex, int @vertexOffset, uint @firstInstance);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdDrawIndirectDelegate(CommandBufferHandle @commandBuffer, BufferHandle @buffer, ulong @offset, uint @drawCount, uint @stride);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdDrawIndexedIndirectDelegate(CommandBufferHandle @commandBuffer, BufferHandle @buffer, ulong @offset, uint @drawCount, uint @stride);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdDispatchDelegate(CommandBufferHandle @commandBuffer, uint @x, uint @y, uint @z);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdDispatchIndirectDelegate(CommandBufferHandle @commandBuffer, BufferHandle @buffer, ulong @offset);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdCopyBufferDelegate(CommandBufferHandle @commandBuffer, BufferHandle @srcBuffer, BufferHandle @dstBuffer, uint @regionCount, BufferCopy @pRegions);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdCopyImageDelegate(CommandBufferHandle @commandBuffer, ImageHandle @srcImage, ImageLayout @srcImageLayout, ImageHandle @dstImage, ImageLayout @dstImageLayout, uint @regionCount, ImageCopy @pRegions);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdBlitImageDelegate(CommandBufferHandle @commandBuffer, ImageHandle @srcImage, ImageLayout @srcImageLayout, ImageHandle @dstImage, ImageLayout @dstImageLayout, uint @regionCount, ImageBlit @pRegions, Filter @filter);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdCopyBufferToImageDelegate(CommandBufferHandle @commandBuffer, BufferHandle @srcBuffer, ImageHandle @dstImage, ImageLayout @dstImageLayout, uint @regionCount, BufferImageCopy @pRegions);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdCopyImageToBufferDelegate(CommandBufferHandle @commandBuffer, ImageHandle @srcImage, ImageLayout @srcImageLayout, BufferHandle @dstBuffer, uint @regionCount, BufferImageCopy @pRegions);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdUpdateBufferDelegate(CommandBufferHandle @commandBuffer, BufferHandle @dstBuffer, ulong @dstOffset, ulong @dataSize, IntPtr @pData);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdFillBufferDelegate(CommandBufferHandle @commandBuffer, BufferHandle @dstBuffer, ulong @dstOffset, ulong @size, uint @data);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdClearColorImageDelegate(CommandBufferHandle @commandBuffer, ImageHandle @image, ImageLayout @imageLayout, ClearColorValue @pColor, uint @rangeCount, ImageSubresourceRange @pRanges);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdClearDepthStencilImageDelegate(CommandBufferHandle @commandBuffer, ImageHandle @image, ImageLayout @imageLayout, ClearDepthStencilValue @pDepthStencil, uint @rangeCount, ImageSubresourceRange @pRanges);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdClearAttachmentsDelegate(CommandBufferHandle @commandBuffer, uint @attachmentCount, ClearAttachment @pAttachments, uint @rectCount, ClearRect @pRects);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdResolveImageDelegate(CommandBufferHandle @commandBuffer, ImageHandle @srcImage, ImageLayout @srcImageLayout, ImageHandle @dstImage, ImageLayout @dstImageLayout, uint @regionCount, ImageResolve @pRegions);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdSetEventDelegate(CommandBufferHandle @commandBuffer, EventHandle @event, PipelineStageFlags @stageMask);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdResetEventDelegate(CommandBufferHandle @commandBuffer, EventHandle @event, PipelineStageFlags @stageMask);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdWaitEventsDelegate(CommandBufferHandle @commandBuffer, uint @eventCount, EventHandle @pEvents, PipelineStageFlags @srcStageMask, PipelineStageFlags @dstStageMask, uint @memoryBarrierCount, MemoryBarrier @pMemoryBarriers, uint @bufferMemoryBarrierCount, BufferMemoryBarrier @pBufferMemoryBarriers, uint @imageMemoryBarrierCount, ImageMemoryBarrier @pImageMemoryBarriers);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdPipelineBarrierDelegate(CommandBufferHandle @commandBuffer, PipelineStageFlags @srcStageMask, PipelineStageFlags @dstStageMask, DependencyFlags @dependencyFlags, uint @memoryBarrierCount, MemoryBarrier @pMemoryBarriers, uint @bufferMemoryBarrierCount, BufferMemoryBarrier @pBufferMemoryBarriers, uint @imageMemoryBarrierCount, ImageMemoryBarrier @pImageMemoryBarriers);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdBeginQueryDelegate(CommandBufferHandle @commandBuffer, QueryPoolHandle @queryPool, uint @query, QueryControlFlags @flags);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdEndQueryDelegate(CommandBufferHandle @commandBuffer, QueryPoolHandle @queryPool, uint @query);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdResetQueryPoolDelegate(CommandBufferHandle @commandBuffer, QueryPoolHandle @queryPool, uint @firstQuery, uint @queryCount);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdWriteTimestampDelegate(CommandBufferHandle @commandBuffer, PipelineStageFlags @pipelineStage, QueryPoolHandle @queryPool, uint @query);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdCopyQueryPoolResultsDelegate(CommandBufferHandle @commandBuffer, QueryPoolHandle @queryPool, uint @firstQuery, uint @queryCount, BufferHandle @dstBuffer, ulong @dstOffset, ulong @stride, QueryResultFlags @flags);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdPushConstantsDelegate(CommandBufferHandle @commandBuffer, PipelineLayoutHandle @layout, ShaderStageFlags @stageFlags, uint @offset, uint @size, IntPtr @pValues);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdBeginRenderPassDelegate(CommandBufferHandle @commandBuffer, RenderPassBeginInfo @pRenderPassBegin, SubpassContents @contents);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdNextSubpassDelegate(CommandBufferHandle @commandBuffer, SubpassContents @contents);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdEndRenderPassDelegate(CommandBufferHandle @commandBuffer);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdExecuteCommandsDelegate(CommandBufferHandle @commandBuffer, uint @commandBufferCount, CommandBufferHandle @pCommandBuffers);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateAndroidSurfaceKhrDelegate(InstanceHandle @instance, AndroidSurfaceCreateInfoKhr @pCreateInfo, AllocationCallbacks @pAllocator, SurfaceKhrHandle @pSurface);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result GetPhysicalDeviceDisplayPropertiesKhrDelegate(PhysicalDeviceHandle @physicalDevice, uint @pPropertyCount, DisplayPropertiesKhr @pProperties);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result GetPhysicalDeviceDisplayPlanePropertiesKhrDelegate(PhysicalDeviceHandle @physicalDevice, uint @pPropertyCount, DisplayPlanePropertiesKhr @pProperties);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result GetDisplayPlaneSupportedDisplaysKhrDelegate(PhysicalDeviceHandle @physicalDevice, uint @planeIndex, uint @pDisplayCount, DisplayKhrHandle @pDisplays);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result GetDisplayModePropertiesKhrDelegate(PhysicalDeviceHandle @physicalDevice, DisplayKhrHandle @display, uint @pPropertyCount, DisplayModePropertiesKhr @pProperties);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateDisplayModeKhrDelegate(PhysicalDeviceHandle @physicalDevice, DisplayKhrHandle @display, DisplayModeCreateInfoKhr @pCreateInfo, AllocationCallbacks @pAllocator, DisplayModeKhrHandle @pMode);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result GetDisplayPlaneCapabilitiesKhrDelegate(PhysicalDeviceHandle @physicalDevice, DisplayModeKhrHandle @mode, uint @planeIndex, DisplayPlaneCapabilitiesKhr @pCapabilities);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateDisplayPlaneSurfaceKhrDelegate(InstanceHandle @instance, DisplaySurfaceCreateInfoKhr @pCreateInfo, AllocationCallbacks @pAllocator, SurfaceKhrHandle @pSurface);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateSharedSwapchainsKhrDelegate(DeviceHandle @device, uint @swapchainCount, SwapchainCreateInfoKhr @pCreateInfos, AllocationCallbacks @pAllocator, SwapchainKhrHandle @pSwapchains);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateMirSurfaceKhrDelegate(InstanceHandle @instance, MirSurfaceCreateInfoKhr @pCreateInfo, AllocationCallbacks @pAllocator, SurfaceKhrHandle @pSurface);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate uint GetPhysicalDeviceMirPresentationSupportKhrDelegate(PhysicalDeviceHandle @physicalDevice, uint @queueFamilyIndex, IntPtr @connection);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr DestroySurfaceKhrDelegate(InstanceHandle @instance, SurfaceKhrHandle @surface, AllocationCallbacks @pAllocator);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result GetPhysicalDeviceSurfaceSupportKhrDelegate(PhysicalDeviceHandle @physicalDevice, uint @queueFamilyIndex, SurfaceKhrHandle @surface, uint @pSupported);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result GetPhysicalDeviceSurfaceCapabilitiesKhrDelegate(PhysicalDeviceHandle @physicalDevice, SurfaceKhrHandle @surface, SurfaceCapabilitiesKhr @pSurfaceCapabilities);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result GetPhysicalDeviceSurfaceFormatsKhrDelegate(PhysicalDeviceHandle @physicalDevice, SurfaceKhrHandle @surface, uint @pSurfaceFormatCount, SurfaceFormatKhr @pSurfaceFormats);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result GetPhysicalDeviceSurfacePresentModesKhrDelegate(PhysicalDeviceHandle @physicalDevice, SurfaceKhrHandle @surface, uint @pPresentModeCount, PresentModeKhr @pPresentModes);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateSwapchainKhrDelegate(DeviceHandle @device, SwapchainCreateInfoKhr @pCreateInfo, AllocationCallbacks @pAllocator, SwapchainKhrHandle @pSwapchain);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr DestroySwapchainKhrDelegate(DeviceHandle @device, SwapchainKhrHandle @swapchain, AllocationCallbacks @pAllocator);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result GetSwapchainImagesKhrDelegate(DeviceHandle @device, SwapchainKhrHandle @swapchain, uint @pSwapchainImageCount, ImageHandle @pSwapchainImages);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result AcquireNextImageKhrDelegate(DeviceHandle @device, SwapchainKhrHandle @swapchain, ulong @timeout, SemaphoreHandle @semaphore, FenceHandle @fence, uint @pImageIndex);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result QueuePresentKhrDelegate(QueueHandle @queue, PresentInfoKhr @pPresentInfo);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateWaylandSurfaceKhrDelegate(InstanceHandle @instance, WaylandSurfaceCreateInfoKhr @pCreateInfo, AllocationCallbacks @pAllocator, SurfaceKhrHandle @pSurface);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate uint GetPhysicalDeviceWaylandPresentationSupportKhrDelegate(PhysicalDeviceHandle @physicalDevice, uint @queueFamilyIndex, IntPtr @display);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateWin32SurfaceKhrDelegate(InstanceHandle @instance, Win32SurfaceCreateInfoKhr @pCreateInfo, AllocationCallbacks @pAllocator, SurfaceKhrHandle @pSurface);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate uint GetPhysicalDeviceWin32PresentationSupportKhrDelegate(PhysicalDeviceHandle @physicalDevice, uint @queueFamilyIndex);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateXlibSurfaceKhrDelegate(InstanceHandle @instance, XlibSurfaceCreateInfoKhr @pCreateInfo, AllocationCallbacks @pAllocator, SurfaceKhrHandle @pSurface);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate uint GetPhysicalDeviceXlibPresentationSupportKhrDelegate(PhysicalDeviceHandle @physicalDevice, uint @queueFamilyIndex, IntPtr @dpy, IntPtr @visualID);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateXcbSurfaceKhrDelegate(InstanceHandle @instance, XcbSurfaceCreateInfoKhr @pCreateInfo, AllocationCallbacks @pAllocator, SurfaceKhrHandle @pSurface);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate uint GetPhysicalDeviceXcbPresentationSupportKhrDelegate(PhysicalDeviceHandle @physicalDevice, uint @queueFamilyIndex, IntPtr @connection, IntPtr @visual_id);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateDebugReportCallbackExtDelegate(InstanceHandle @instance, DebugReportCallbackCreateInfoExt @pCreateInfo, AllocationCallbacks @pAllocator, DebugReportCallbackExtHandle @pCallback);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr DestroyDebugReportCallbackExtDelegate(InstanceHandle @instance, DebugReportCallbackExtHandle @callback, AllocationCallbacks @pAllocator);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr DebugReportMessageExtDelegate(InstanceHandle @instance, DebugReportFlagsExt @flags, DebugReportObjectTypeExt @objectType, ulong @object, UIntPtr @location, int @messageCode, byte @pLayerPrefix, byte @pMessage);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result DebugMarkerSetObjectNameExtDelegate(DeviceHandle @device, DebugMarkerObjectNameInfoExt @pNameInfo);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result DebugMarkerSetObjectTagExtDelegate(DeviceHandle @device, DebugMarkerObjectTagInfoExt @pTagInfo);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdDebugMarkerBeginExtDelegate(CommandBufferHandle @commandBuffer, DebugMarkerMarkerInfoExt @pMarkerInfo);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdDebugMarkerEndExtDelegate(CommandBufferHandle @commandBuffer);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdDebugMarkerInsertExtDelegate(CommandBufferHandle @commandBuffer, DebugMarkerMarkerInfoExt @pMarkerInfo);
    }
}