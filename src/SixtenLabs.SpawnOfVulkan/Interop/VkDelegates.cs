using System;
using System.Runtime.InteropServices;

namespace SixtenLabs.SpawnOfVulkan
{
    public static partial class Vk
    {
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateInstanceDelegate(InstanceCreateInfo @pCreateInfo, AllocationCallbacks @pAllocator, Instance @pInstance);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr DestroyInstanceDelegate(Instance @instance, AllocationCallbacks @pAllocator);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result EnumeratePhysicalDevicesDelegate(Instance @instance, uint @pPhysicalDeviceCount, PhysicalDevice @pPhysicalDevices);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr GetDeviceProcAddrDelegate(Device @device, string @pName);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr GetInstanceProcAddrDelegate(Instance @instance, string @pName);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr GetPhysicalDevicePropertiesDelegate(PhysicalDevice @physicalDevice, PhysicalDeviceProperties @pProperties);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr GetPhysicalDeviceQueueFamilyPropertiesDelegate(PhysicalDevice @physicalDevice, uint @pQueueFamilyPropertyCount, QueueFamilyProperties @pQueueFamilyProperties);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr GetPhysicalDeviceMemoryPropertiesDelegate(PhysicalDevice @physicalDevice, PhysicalDeviceMemoryProperties @pMemoryProperties);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr GetPhysicalDeviceFeaturesDelegate(PhysicalDevice @physicalDevice, PhysicalDeviceFeatures @pFeatures);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr GetPhysicalDeviceFormatPropertiesDelegate(PhysicalDevice @physicalDevice, Format @format, FormatProperties @pFormatProperties);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result GetPhysicalDeviceImageFormatPropertiesDelegate(PhysicalDevice @physicalDevice, Format @format, ImageType @type, ImageTiling @tiling, ImageUsageFlags @usage, ImageCreateFlags @flags, ImageFormatProperties @pImageFormatProperties);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateDeviceDelegate(PhysicalDevice @physicalDevice, DeviceCreateInfo @pCreateInfo, AllocationCallbacks @pAllocator, Device @pDevice);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr DestroyDeviceDelegate(Device @device, AllocationCallbacks @pAllocator);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result EnumerateInstanceLayerPropertiesDelegate(uint @pPropertyCount, LayerProperties @pProperties);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result EnumerateInstanceExtensionPropertiesDelegate(string @pLayerName, uint @pPropertyCount, ExtensionProperties @pProperties);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result EnumerateDeviceLayerPropertiesDelegate(PhysicalDevice @physicalDevice, uint @pPropertyCount, LayerProperties @pProperties);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result EnumerateDeviceExtensionPropertiesDelegate(PhysicalDevice @physicalDevice, string @pLayerName, uint @pPropertyCount, ExtensionProperties @pProperties);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr GetDeviceQueueDelegate(Device @device, uint @queueFamilyIndex, uint @queueIndex, Queue @pQueue);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result QueueSubmitDelegate(Queue @queue, uint @submitCount, SubmitInfo @pSubmits, Fence @fence);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result QueueWaitIdleDelegate(Queue @queue);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result DeviceWaitIdleDelegate(Device @device);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result AllocateMemoryDelegate(Device @device, MemoryAllocateInfo @pAllocateInfo, AllocationCallbacks @pAllocator, DeviceMemory @pMemory);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr FreeMemoryDelegate(Device @device, DeviceMemory @memory, AllocationCallbacks @pAllocator);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result MapMemoryDelegate(Device @device, DeviceMemory @memory, ulong @offset, ulong @size, MemoryMapFlags @flags, IntPtr @ppData);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr UnmapMemoryDelegate(Device @device, DeviceMemory @memory);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result FlushMappedMemoryRangesDelegate(Device @device, uint @memoryRangeCount, MappedMemoryRange @pMemoryRanges);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result InvalidateMappedMemoryRangesDelegate(Device @device, uint @memoryRangeCount, MappedMemoryRange @pMemoryRanges);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr GetDeviceMemoryCommitmentDelegate(Device @device, DeviceMemory @memory, ulong @pCommittedMemoryInBytes);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr GetBufferMemoryRequirementsDelegate(Device @device, Buffer @buffer, MemoryRequirements @pMemoryRequirements);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result BindBufferMemoryDelegate(Device @device, Buffer @buffer, DeviceMemory @memory, ulong @memoryOffset);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr GetImageMemoryRequirementsDelegate(Device @device, Image @image, MemoryRequirements @pMemoryRequirements);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result BindImageMemoryDelegate(Device @device, Image @image, DeviceMemory @memory, ulong @memoryOffset);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr GetImageSparseMemoryRequirementsDelegate(Device @device, Image @image, uint @pSparseMemoryRequirementCount, SparseImageMemoryRequirements @pSparseMemoryRequirements);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr GetPhysicalDeviceSparseImageFormatPropertiesDelegate(PhysicalDevice @physicalDevice, Format @format, ImageType @type, SampleCountFlags @samples, ImageUsageFlags @usage, ImageTiling @tiling, uint @pPropertyCount, SparseImageFormatProperties @pProperties);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result QueueBindSparseDelegate(Queue @queue, uint @bindInfoCount, BindSparseInfo @pBindInfo, Fence @fence);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateFenceDelegate(Device @device, FenceCreateInfo @pCreateInfo, AllocationCallbacks @pAllocator, Fence @pFence);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr DestroyFenceDelegate(Device @device, Fence @fence, AllocationCallbacks @pAllocator);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result ResetFencesDelegate(Device @device, uint @fenceCount, Fence @pFences);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result GetFenceStatusDelegate(Device @device, Fence @fence);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result WaitForFencesDelegate(Device @device, uint @fenceCount, Fence @pFences, uint @waitAll, ulong @timeout);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateSemaphoreDelegate(Device @device, SemaphoreCreateInfo @pCreateInfo, AllocationCallbacks @pAllocator, Semaphore @pSemaphore);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr DestroySemaphoreDelegate(Device @device, Semaphore @semaphore, AllocationCallbacks @pAllocator);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateEventDelegate(Device @device, EventCreateInfo @pCreateInfo, AllocationCallbacks @pAllocator, Event @pEvent);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr DestroyEventDelegate(Device @device, Event @event, AllocationCallbacks @pAllocator);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result GetEventStatusDelegate(Device @device, Event @event);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result SetEventDelegate(Device @device, Event @event);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result ResetEventDelegate(Device @device, Event @event);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateQueryPoolDelegate(Device @device, QueryPoolCreateInfo @pCreateInfo, AllocationCallbacks @pAllocator, QueryPool @pQueryPool);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr DestroyQueryPoolDelegate(Device @device, QueryPool @queryPool, AllocationCallbacks @pAllocator);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result GetQueryPoolResultsDelegate(Device @device, QueryPool @queryPool, uint @firstQuery, uint @queryCount, UIntPtr @dataSize, IntPtr @pData, ulong @stride, QueryResultFlags @flags);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateBufferDelegate(Device @device, BufferCreateInfo @pCreateInfo, AllocationCallbacks @pAllocator, Buffer @pBuffer);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr DestroyBufferDelegate(Device @device, Buffer @buffer, AllocationCallbacks @pAllocator);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateBufferViewDelegate(Device @device, BufferViewCreateInfo @pCreateInfo, AllocationCallbacks @pAllocator, BufferView @pView);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr DestroyBufferViewDelegate(Device @device, BufferView @bufferView, AllocationCallbacks @pAllocator);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateImageDelegate(Device @device, ImageCreateInfo @pCreateInfo, AllocationCallbacks @pAllocator, Image @pImage);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr DestroyImageDelegate(Device @device, Image @image, AllocationCallbacks @pAllocator);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr GetImageSubresourceLayoutDelegate(Device @device, Image @image, ImageSubresource @pSubresource, SubresourceLayout @pLayout);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateImageViewDelegate(Device @device, ImageViewCreateInfo @pCreateInfo, AllocationCallbacks @pAllocator, ImageView @pView);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr DestroyImageViewDelegate(Device @device, ImageView @imageView, AllocationCallbacks @pAllocator);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateShaderModuleDelegate(Device @device, ShaderModuleCreateInfo @pCreateInfo, AllocationCallbacks @pAllocator, ShaderModule @pShaderModule);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr DestroyShaderModuleDelegate(Device @device, ShaderModule @shaderModule, AllocationCallbacks @pAllocator);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreatePipelineCacheDelegate(Device @device, PipelineCacheCreateInfo @pCreateInfo, AllocationCallbacks @pAllocator, PipelineCache @pPipelineCache);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr DestroyPipelineCacheDelegate(Device @device, PipelineCache @pipelineCache, AllocationCallbacks @pAllocator);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result GetPipelineCacheDataDelegate(Device @device, PipelineCache @pipelineCache, UIntPtr @pDataSize, IntPtr @pData);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result MergePipelineCachesDelegate(Device @device, PipelineCache @dstCache, uint @srcCacheCount, PipelineCache @pSrcCaches);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateGraphicsPipelinesDelegate(Device @device, PipelineCache @pipelineCache, uint @createInfoCount, GraphicsPipelineCreateInfo @pCreateInfos, AllocationCallbacks @pAllocator, Pipeline @pPipelines);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateComputePipelinesDelegate(Device @device, PipelineCache @pipelineCache, uint @createInfoCount, ComputePipelineCreateInfo @pCreateInfos, AllocationCallbacks @pAllocator, Pipeline @pPipelines);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr DestroyPipelineDelegate(Device @device, Pipeline @pipeline, AllocationCallbacks @pAllocator);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreatePipelineLayoutDelegate(Device @device, PipelineLayoutCreateInfo @pCreateInfo, AllocationCallbacks @pAllocator, PipelineLayout @pPipelineLayout);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr DestroyPipelineLayoutDelegate(Device @device, PipelineLayout @pipelineLayout, AllocationCallbacks @pAllocator);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateSamplerDelegate(Device @device, SamplerCreateInfo @pCreateInfo, AllocationCallbacks @pAllocator, Sampler @pSampler);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr DestroySamplerDelegate(Device @device, Sampler @sampler, AllocationCallbacks @pAllocator);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateDescriptorSetLayoutDelegate(Device @device, DescriptorSetLayoutCreateInfo @pCreateInfo, AllocationCallbacks @pAllocator, DescriptorSetLayout @pSetLayout);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr DestroyDescriptorSetLayoutDelegate(Device @device, DescriptorSetLayout @descriptorSetLayout, AllocationCallbacks @pAllocator);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateDescriptorPoolDelegate(Device @device, DescriptorPoolCreateInfo @pCreateInfo, AllocationCallbacks @pAllocator, DescriptorPool @pDescriptorPool);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr DestroyDescriptorPoolDelegate(Device @device, DescriptorPool @descriptorPool, AllocationCallbacks @pAllocator);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result ResetDescriptorPoolDelegate(Device @device, DescriptorPool @descriptorPool, DescriptorPoolResetFlags @flags);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result AllocateDescriptorSetsDelegate(Device @device, DescriptorSetAllocateInfo @pAllocateInfo, DescriptorSet @pDescriptorSets);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result FreeDescriptorSetsDelegate(Device @device, DescriptorPool @descriptorPool, uint @descriptorSetCount, DescriptorSet @pDescriptorSets);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr UpdateDescriptorSetsDelegate(Device @device, uint @descriptorWriteCount, WriteDescriptorSet @pDescriptorWrites, uint @descriptorCopyCount, CopyDescriptorSet @pDescriptorCopies);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateFramebufferDelegate(Device @device, FramebufferCreateInfo @pCreateInfo, AllocationCallbacks @pAllocator, Framebuffer @pFramebuffer);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr DestroyFramebufferDelegate(Device @device, Framebuffer @framebuffer, AllocationCallbacks @pAllocator);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateRenderPassDelegate(Device @device, RenderPassCreateInfo @pCreateInfo, AllocationCallbacks @pAllocator, RenderPass @pRenderPass);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr DestroyRenderPassDelegate(Device @device, RenderPass @renderPass, AllocationCallbacks @pAllocator);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr GetRenderAreaGranularityDelegate(Device @device, RenderPass @renderPass, Extent2D @pGranularity);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateCommandPoolDelegate(Device @device, CommandPoolCreateInfo @pCreateInfo, AllocationCallbacks @pAllocator, CommandPool @pCommandPool);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr DestroyCommandPoolDelegate(Device @device, CommandPool @commandPool, AllocationCallbacks @pAllocator);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result ResetCommandPoolDelegate(Device @device, CommandPool @commandPool, CommandPoolResetFlags @flags);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result AllocateCommandBuffersDelegate(Device @device, CommandBufferAllocateInfo @pAllocateInfo, CommandBuffer @pCommandBuffers);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr FreeCommandBuffersDelegate(Device @device, CommandPool @commandPool, uint @commandBufferCount, CommandBuffer @pCommandBuffers);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result BeginCommandBufferDelegate(CommandBuffer @commandBuffer, CommandBufferBeginInfo @pBeginInfo);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result EndCommandBufferDelegate(CommandBuffer @commandBuffer);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result ResetCommandBufferDelegate(CommandBuffer @commandBuffer, CommandBufferResetFlags @flags);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdBindPipelineDelegate(CommandBuffer @commandBuffer, PipelineBindPoint @pipelineBindPoint, Pipeline @pipeline);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdSetViewportDelegate(CommandBuffer @commandBuffer, uint @firstViewport, uint @viewportCount, Viewport @pViewports);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdSetScissorDelegate(CommandBuffer @commandBuffer, uint @firstScissor, uint @scissorCount, Rect2D @pScissors);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdSetLineWidthDelegate(CommandBuffer @commandBuffer, float @lineWidth);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdSetDepthBiasDelegate(CommandBuffer @commandBuffer, float @depthBiasConstantFactor, float @depthBiasClamp, float @depthBiasSlopeFactor);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdSetBlendConstantsDelegate(CommandBuffer @commandBuffer, float @blendConstants);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdSetDepthBoundsDelegate(CommandBuffer @commandBuffer, float @minDepthBounds, float @maxDepthBounds);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdSetStencilCompareMaskDelegate(CommandBuffer @commandBuffer, StencilFaceFlags @faceMask, uint @compareMask);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdSetStencilWriteMaskDelegate(CommandBuffer @commandBuffer, StencilFaceFlags @faceMask, uint @writeMask);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdSetStencilReferenceDelegate(CommandBuffer @commandBuffer, StencilFaceFlags @faceMask, uint @reference);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdBindDescriptorSetsDelegate(CommandBuffer @commandBuffer, PipelineBindPoint @pipelineBindPoint, PipelineLayout @layout, uint @firstSet, uint @descriptorSetCount, DescriptorSet @pDescriptorSets, uint @dynamicOffsetCount, uint @pDynamicOffsets);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdBindIndexBufferDelegate(CommandBuffer @commandBuffer, Buffer @buffer, ulong @offset, IndexType @indexType);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdBindVertexBuffersDelegate(CommandBuffer @commandBuffer, uint @firstBinding, uint @bindingCount, Buffer @pBuffers, ulong @pOffsets);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdDrawDelegate(CommandBuffer @commandBuffer, uint @vertexCount, uint @instanceCount, uint @firstVertex, uint @firstInstance);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdDrawIndexedDelegate(CommandBuffer @commandBuffer, uint @indexCount, uint @instanceCount, uint @firstIndex, int @vertexOffset, uint @firstInstance);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdDrawIndirectDelegate(CommandBuffer @commandBuffer, Buffer @buffer, ulong @offset, uint @drawCount, uint @stride);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdDrawIndexedIndirectDelegate(CommandBuffer @commandBuffer, Buffer @buffer, ulong @offset, uint @drawCount, uint @stride);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdDispatchDelegate(CommandBuffer @commandBuffer, uint @x, uint @y, uint @z);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdDispatchIndirectDelegate(CommandBuffer @commandBuffer, Buffer @buffer, ulong @offset);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdCopyBufferDelegate(CommandBuffer @commandBuffer, Buffer @srcBuffer, Buffer @dstBuffer, uint @regionCount, BufferCopy @pRegions);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdCopyImageDelegate(CommandBuffer @commandBuffer, Image @srcImage, ImageLayout @srcImageLayout, Image @dstImage, ImageLayout @dstImageLayout, uint @regionCount, ImageCopy @pRegions);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdBlitImageDelegate(CommandBuffer @commandBuffer, Image @srcImage, ImageLayout @srcImageLayout, Image @dstImage, ImageLayout @dstImageLayout, uint @regionCount, ImageBlit @pRegions, Filter @filter);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdCopyBufferToImageDelegate(CommandBuffer @commandBuffer, Buffer @srcBuffer, Image @dstImage, ImageLayout @dstImageLayout, uint @regionCount, BufferImageCopy @pRegions);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdCopyImageToBufferDelegate(CommandBuffer @commandBuffer, Image @srcImage, ImageLayout @srcImageLayout, Buffer @dstBuffer, uint @regionCount, BufferImageCopy @pRegions);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdUpdateBufferDelegate(CommandBuffer @commandBuffer, Buffer @dstBuffer, ulong @dstOffset, ulong @dataSize, uint @pData);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdFillBufferDelegate(CommandBuffer @commandBuffer, Buffer @dstBuffer, ulong @dstOffset, ulong @size, uint @data);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdClearColorImageDelegate(CommandBuffer @commandBuffer, Image @image, ImageLayout @imageLayout, ClearColorValue @pColor, uint @rangeCount, ImageSubresourceRange @pRanges);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdClearDepthStencilImageDelegate(CommandBuffer @commandBuffer, Image @image, ImageLayout @imageLayout, ClearDepthStencilValue @pDepthStencil, uint @rangeCount, ImageSubresourceRange @pRanges);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdClearAttachmentsDelegate(CommandBuffer @commandBuffer, uint @attachmentCount, ClearAttachment @pAttachments, uint @rectCount, ClearRect @pRects);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdResolveImageDelegate(CommandBuffer @commandBuffer, Image @srcImage, ImageLayout @srcImageLayout, Image @dstImage, ImageLayout @dstImageLayout, uint @regionCount, ImageResolve @pRegions);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdSetEventDelegate(CommandBuffer @commandBuffer, Event @event, PipelineStageFlags @stageMask);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdResetEventDelegate(CommandBuffer @commandBuffer, Event @event, PipelineStageFlags @stageMask);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdWaitEventsDelegate(CommandBuffer @commandBuffer, uint @eventCount, Event @pEvents, PipelineStageFlags @srcStageMask, PipelineStageFlags @dstStageMask, uint @memoryBarrierCount, MemoryBarrier @pMemoryBarriers, uint @bufferMemoryBarrierCount, BufferMemoryBarrier @pBufferMemoryBarriers, uint @imageMemoryBarrierCount, ImageMemoryBarrier @pImageMemoryBarriers);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdPipelineBarrierDelegate(CommandBuffer @commandBuffer, PipelineStageFlags @srcStageMask, PipelineStageFlags @dstStageMask, DependencyFlags @dependencyFlags, uint @memoryBarrierCount, MemoryBarrier @pMemoryBarriers, uint @bufferMemoryBarrierCount, BufferMemoryBarrier @pBufferMemoryBarriers, uint @imageMemoryBarrierCount, ImageMemoryBarrier @pImageMemoryBarriers);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdBeginQueryDelegate(CommandBuffer @commandBuffer, QueryPool @queryPool, uint @query, QueryControlFlags @flags);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdEndQueryDelegate(CommandBuffer @commandBuffer, QueryPool @queryPool, uint @query);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdResetQueryPoolDelegate(CommandBuffer @commandBuffer, QueryPool @queryPool, uint @firstQuery, uint @queryCount);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdWriteTimestampDelegate(CommandBuffer @commandBuffer, PipelineStageFlags @pipelineStage, QueryPool @queryPool, uint @query);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdCopyQueryPoolResultsDelegate(CommandBuffer @commandBuffer, QueryPool @queryPool, uint @firstQuery, uint @queryCount, Buffer @dstBuffer, ulong @dstOffset, ulong @stride, QueryResultFlags @flags);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdPushConstantsDelegate(CommandBuffer @commandBuffer, PipelineLayout @layout, ShaderStageFlags @stageFlags, uint @offset, uint @size, IntPtr @pValues);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdBeginRenderPassDelegate(CommandBuffer @commandBuffer, RenderPassBeginInfo @pRenderPassBegin, SubpassContents @contents);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdNextSubpassDelegate(CommandBuffer @commandBuffer, SubpassContents @contents);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdEndRenderPassDelegate(CommandBuffer @commandBuffer);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdExecuteCommandsDelegate(CommandBuffer @commandBuffer, uint @commandBufferCount, CommandBuffer @pCommandBuffers);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateAndroidSurfaceKhrDelegate(Instance @instance, AndroidSurfaceCreateInfoKhr @pCreateInfo, AllocationCallbacks @pAllocator, SurfaceKhr @pSurface);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result GetPhysicalDeviceDisplayPropertiesKhrDelegate(PhysicalDevice @physicalDevice, uint @pPropertyCount, DisplayPropertiesKhr @pProperties);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result GetPhysicalDeviceDisplayPlanePropertiesKhrDelegate(PhysicalDevice @physicalDevice, uint @pPropertyCount, DisplayPlanePropertiesKhr @pProperties);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result GetDisplayPlaneSupportedDisplaysKhrDelegate(PhysicalDevice @physicalDevice, uint @planeIndex, uint @pDisplayCount, DisplayKhr @pDisplays);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result GetDisplayModePropertiesKhrDelegate(PhysicalDevice @physicalDevice, DisplayKhr @display, uint @pPropertyCount, DisplayModePropertiesKhr @pProperties);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateDisplayModeKhrDelegate(PhysicalDevice @physicalDevice, DisplayKhr @display, DisplayModeCreateInfoKhr @pCreateInfo, AllocationCallbacks @pAllocator, DisplayModeKhr @pMode);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result GetDisplayPlaneCapabilitiesKhrDelegate(PhysicalDevice @physicalDevice, DisplayModeKhr @mode, uint @planeIndex, DisplayPlaneCapabilitiesKhr @pCapabilities);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateDisplayPlaneSurfaceKhrDelegate(Instance @instance, DisplaySurfaceCreateInfoKhr @pCreateInfo, AllocationCallbacks @pAllocator, SurfaceKhr @pSurface);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateSharedSwapchainsKhrDelegate(Device @device, uint @swapchainCount, SwapchainCreateInfoKhr @pCreateInfos, AllocationCallbacks @pAllocator, SwapchainKhr @pSwapchains);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateMirSurfaceKhrDelegate(Instance @instance, MirSurfaceCreateInfoKhr @pCreateInfo, AllocationCallbacks @pAllocator, SurfaceKhr @pSurface);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate uint GetPhysicalDeviceMirPresentationSupportKhrDelegate(PhysicalDevice @physicalDevice, uint @queueFamilyIndex, IntPtr @connection);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr DestroySurfaceKhrDelegate(Instance @instance, SurfaceKhr @surface, AllocationCallbacks @pAllocator);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result GetPhysicalDeviceSurfaceSupportKhrDelegate(PhysicalDevice @physicalDevice, uint @queueFamilyIndex, SurfaceKhr @surface, uint @pSupported);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result GetPhysicalDeviceSurfaceCapabilitiesKhrDelegate(PhysicalDevice @physicalDevice, SurfaceKhr @surface, SurfaceCapabilitiesKhr @pSurfaceCapabilities);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result GetPhysicalDeviceSurfaceFormatsKhrDelegate(PhysicalDevice @physicalDevice, SurfaceKhr @surface, uint @pSurfaceFormatCount, SurfaceFormatKhr @pSurfaceFormats);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result GetPhysicalDeviceSurfacePresentModesKhrDelegate(PhysicalDevice @physicalDevice, SurfaceKhr @surface, uint @pPresentModeCount, PresentModeKhr @pPresentModes);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateSwapchainKhrDelegate(Device @device, SwapchainCreateInfoKhr @pCreateInfo, AllocationCallbacks @pAllocator, SwapchainKhr @pSwapchain);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr DestroySwapchainKhrDelegate(Device @device, SwapchainKhr @swapchain, AllocationCallbacks @pAllocator);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result GetSwapchainImagesKhrDelegate(Device @device, SwapchainKhr @swapchain, uint @pSwapchainImageCount, Image @pSwapchainImages);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result AcquireNextImageKhrDelegate(Device @device, SwapchainKhr @swapchain, ulong @timeout, Semaphore @semaphore, Fence @fence, uint @pImageIndex);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result QueuePresentKhrDelegate(Queue @queue, PresentInfoKhr @pPresentInfo);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateWaylandSurfaceKhrDelegate(Instance @instance, WaylandSurfaceCreateInfoKhr @pCreateInfo, AllocationCallbacks @pAllocator, SurfaceKhr @pSurface);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate uint GetPhysicalDeviceWaylandPresentationSupportKhrDelegate(PhysicalDevice @physicalDevice, uint @queueFamilyIndex, IntPtr @display);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateWin32SurfaceKhrDelegate(Instance @instance, Win32SurfaceCreateInfoKhr @pCreateInfo, AllocationCallbacks @pAllocator, SurfaceKhr @pSurface);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate uint GetPhysicalDeviceWin32PresentationSupportKhrDelegate(PhysicalDevice @physicalDevice, uint @queueFamilyIndex);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateXlibSurfaceKhrDelegate(Instance @instance, XlibSurfaceCreateInfoKhr @pCreateInfo, AllocationCallbacks @pAllocator, SurfaceKhr @pSurface);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate uint GetPhysicalDeviceXlibPresentationSupportKhrDelegate(PhysicalDevice @physicalDevice, uint @queueFamilyIndex, IntPtr @dpy, IntPtr @visualID);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateXcbSurfaceKhrDelegate(Instance @instance, XcbSurfaceCreateInfoKhr @pCreateInfo, AllocationCallbacks @pAllocator, SurfaceKhr @pSurface);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate uint GetPhysicalDeviceXcbPresentationSupportKhrDelegate(PhysicalDevice @physicalDevice, uint @queueFamilyIndex, IntPtr @connection, IntPtr @visual_id);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateDebugReportCallbackExtDelegate(Instance @instance, DebugReportCallbackCreateInfoExt @pCreateInfo, AllocationCallbacks @pAllocator, DebugReportCallbackExt @pCallback);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr DestroyDebugReportCallbackExtDelegate(Instance @instance, DebugReportCallbackExt @callback, AllocationCallbacks @pAllocator);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr DebugReportMessageExtDelegate(Instance @instance, DebugReportFlagsExt @flags, DebugReportObjectTypeExt @objectType, ulong @object, UIntPtr @location, int @messageCode, string @pLayerPrefix, string @pMessage);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result DebugMarkerSetObjectNameExtDelegate(Device @device, DebugMarkerObjectNameInfoExt @pNameInfo);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result DebugMarkerSetObjectTagExtDelegate(Device @device, DebugMarkerObjectTagInfoExt @pTagInfo);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdDebugMarkerBeginExtDelegate(CommandBuffer @commandBuffer, DebugMarkerMarkerInfoExt @pMarkerInfo);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdDebugMarkerEndExtDelegate(CommandBuffer @commandBuffer);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdDebugMarkerInsertExtDelegate(CommandBuffer @commandBuffer, DebugMarkerMarkerInfoExt @pMarkerInfo);
    }
}