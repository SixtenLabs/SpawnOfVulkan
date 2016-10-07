using System;
using System.Runtime.InteropServices;

namespace SixtenLabs.SpawnOfVulkan
{
    public static partial class Vk
    {
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateInstanceDelegate(InstanceCreateInfo PCreateInfo, AllocationCallbacks PAllocator, InstanceHandle PInstance);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr DestroyInstanceDelegate(InstanceHandle Instance, AllocationCallbacks PAllocator);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result EnumeratePhysicalDevicesDelegate(InstanceHandle Instance, uint PPhysicalDeviceCount, PhysicalDeviceHandle PPhysicalDevices);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr GetDeviceProcAddrDelegate(DeviceHandle Device, byte PName);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr GetInstanceProcAddrDelegate(InstanceHandle Instance, byte PName);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr GetPhysicalDevicePropertiesDelegate(PhysicalDeviceHandle PhysicalDevice, PhysicalDeviceProperties PProperties);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr GetPhysicalDeviceQueueFamilyPropertiesDelegate(PhysicalDeviceHandle PhysicalDevice, uint PQueueFamilyPropertyCount, QueueFamilyProperties PQueueFamilyProperties);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr GetPhysicalDeviceMemoryPropertiesDelegate(PhysicalDeviceHandle PhysicalDevice, PhysicalDeviceMemoryProperties PMemoryProperties);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr GetPhysicalDeviceFeaturesDelegate(PhysicalDeviceHandle PhysicalDevice, PhysicalDeviceFeatures PFeatures);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr GetPhysicalDeviceFormatPropertiesDelegate(PhysicalDeviceHandle PhysicalDevice, Format Format, FormatProperties PFormatProperties);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result GetPhysicalDeviceImageFormatPropertiesDelegate(PhysicalDeviceHandle PhysicalDevice, Format Format, ImageType Type, ImageTiling Tiling, ImageUsageFlags Usage, ImageCreateFlags Flags, ImageFormatProperties PImageFormatProperties);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateDeviceDelegate(PhysicalDeviceHandle PhysicalDevice, DeviceCreateInfo PCreateInfo, AllocationCallbacks PAllocator, DeviceHandle PDevice);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr DestroyDeviceDelegate(DeviceHandle Device, AllocationCallbacks PAllocator);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result EnumerateInstanceLayerPropertiesDelegate(uint PPropertyCount, LayerProperties PProperties);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result EnumerateInstanceExtensionPropertiesDelegate(byte PLayerName, uint PPropertyCount, ExtensionProperties PProperties);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result EnumerateDeviceLayerPropertiesDelegate(PhysicalDeviceHandle PhysicalDevice, uint PPropertyCount, LayerProperties PProperties);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result EnumerateDeviceExtensionPropertiesDelegate(PhysicalDeviceHandle PhysicalDevice, byte PLayerName, uint PPropertyCount, ExtensionProperties PProperties);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr GetDeviceQueueDelegate(DeviceHandle Device, uint QueueFamilyIndex, uint QueueIndex, QueueHandle PQueue);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result QueueSubmitDelegate(QueueHandle Queue, uint SubmitCount, SubmitInfo PSubmits, FenceHandle Fence);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result QueueWaitIdleDelegate(QueueHandle Queue);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result DeviceWaitIdleDelegate(DeviceHandle Device);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result AllocateMemoryDelegate(DeviceHandle Device, MemoryAllocateInfo PAllocateInfo, AllocationCallbacks PAllocator, DeviceMemoryHandle PMemory);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr FreeMemoryDelegate(DeviceHandle Device, DeviceMemoryHandle Memory, AllocationCallbacks PAllocator);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result MapMemoryDelegate(DeviceHandle Device, DeviceMemoryHandle Memory, ulong Offset, ulong Size, MemoryMapFlags Flags, IntPtr PpData);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr UnmapMemoryDelegate(DeviceHandle Device, DeviceMemoryHandle Memory);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result FlushMappedMemoryRangesDelegate(DeviceHandle Device, uint MemoryRangeCount, MappedMemoryRange PMemoryRanges);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result InvalidateMappedMemoryRangesDelegate(DeviceHandle Device, uint MemoryRangeCount, MappedMemoryRange PMemoryRanges);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr GetDeviceMemoryCommitmentDelegate(DeviceHandle Device, DeviceMemoryHandle Memory, ulong PCommittedMemoryInBytes);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr GetBufferMemoryRequirementsDelegate(DeviceHandle Device, BufferHandle Buffer, MemoryRequirements PMemoryRequirements);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result BindBufferMemoryDelegate(DeviceHandle Device, BufferHandle Buffer, DeviceMemoryHandle Memory, ulong MemoryOffset);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr GetImageMemoryRequirementsDelegate(DeviceHandle Device, ImageHandle Image, MemoryRequirements PMemoryRequirements);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result BindImageMemoryDelegate(DeviceHandle Device, ImageHandle Image, DeviceMemoryHandle Memory, ulong MemoryOffset);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr GetImageSparseMemoryRequirementsDelegate(DeviceHandle Device, ImageHandle Image, uint PSparseMemoryRequirementCount, SparseImageMemoryRequirements PSparseMemoryRequirements);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr GetPhysicalDeviceSparseImageFormatPropertiesDelegate(PhysicalDeviceHandle PhysicalDevice, Format Format, ImageType Type, SampleCountFlags Samples, ImageUsageFlags Usage, ImageTiling Tiling, uint PPropertyCount, SparseImageFormatProperties PProperties);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result QueueBindSparseDelegate(QueueHandle Queue, uint BindInfoCount, BindSparseInfo PBindInfo, FenceHandle Fence);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateFenceDelegate(DeviceHandle Device, FenceCreateInfo PCreateInfo, AllocationCallbacks PAllocator, FenceHandle PFence);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr DestroyFenceDelegate(DeviceHandle Device, FenceHandle Fence, AllocationCallbacks PAllocator);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result ResetFencesDelegate(DeviceHandle Device, uint FenceCount, FenceHandle PFences);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result GetFenceStatusDelegate(DeviceHandle Device, FenceHandle Fence);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result WaitForFencesDelegate(DeviceHandle Device, uint FenceCount, FenceHandle PFences, uint WaitAll, ulong Timeout);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateSemaphoreDelegate(DeviceHandle Device, SemaphoreCreateInfo PCreateInfo, AllocationCallbacks PAllocator, SemaphoreHandle PSemaphore);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr DestroySemaphoreDelegate(DeviceHandle Device, SemaphoreHandle Semaphore, AllocationCallbacks PAllocator);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateEventDelegate(DeviceHandle Device, EventCreateInfo PCreateInfo, AllocationCallbacks PAllocator, EventHandle PEvent);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr DestroyEventDelegate(DeviceHandle Device, EventHandle Event, AllocationCallbacks PAllocator);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result GetEventStatusDelegate(DeviceHandle Device, EventHandle Event);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result SetEventDelegate(DeviceHandle Device, EventHandle Event);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result ResetEventDelegate(DeviceHandle Device, EventHandle Event);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateQueryPoolDelegate(DeviceHandle Device, QueryPoolCreateInfo PCreateInfo, AllocationCallbacks PAllocator, QueryPoolHandle PQueryPool);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr DestroyQueryPoolDelegate(DeviceHandle Device, QueryPoolHandle QueryPool, AllocationCallbacks PAllocator);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result GetQueryPoolResultsDelegate(DeviceHandle Device, QueryPoolHandle QueryPool, uint FirstQuery, uint QueryCount, UIntPtr DataSize, IntPtr PData, ulong Stride, QueryResultFlags Flags);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateBufferDelegate(DeviceHandle Device, BufferCreateInfo PCreateInfo, AllocationCallbacks PAllocator, BufferHandle PBuffer);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr DestroyBufferDelegate(DeviceHandle Device, BufferHandle Buffer, AllocationCallbacks PAllocator);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateBufferViewDelegate(DeviceHandle Device, BufferViewCreateInfo PCreateInfo, AllocationCallbacks PAllocator, BufferViewHandle PView);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr DestroyBufferViewDelegate(DeviceHandle Device, BufferViewHandle BufferView, AllocationCallbacks PAllocator);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateImageDelegate(DeviceHandle Device, ImageCreateInfo PCreateInfo, AllocationCallbacks PAllocator, ImageHandle PImage);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr DestroyImageDelegate(DeviceHandle Device, ImageHandle Image, AllocationCallbacks PAllocator);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr GetImageSubresourceLayoutDelegate(DeviceHandle Device, ImageHandle Image, ImageSubresource PSubresource, SubresourceLayout PLayout);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateImageViewDelegate(DeviceHandle Device, ImageViewCreateInfo PCreateInfo, AllocationCallbacks PAllocator, ImageViewHandle PView);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr DestroyImageViewDelegate(DeviceHandle Device, ImageViewHandle ImageView, AllocationCallbacks PAllocator);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateShaderModuleDelegate(DeviceHandle Device, ShaderModuleCreateInfo PCreateInfo, AllocationCallbacks PAllocator, ShaderModuleHandle PShaderModule);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr DestroyShaderModuleDelegate(DeviceHandle Device, ShaderModuleHandle ShaderModule, AllocationCallbacks PAllocator);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreatePipelineCacheDelegate(DeviceHandle Device, PipelineCacheCreateInfo PCreateInfo, AllocationCallbacks PAllocator, PipelineCacheHandle PPipelineCache);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr DestroyPipelineCacheDelegate(DeviceHandle Device, PipelineCacheHandle PipelineCache, AllocationCallbacks PAllocator);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result GetPipelineCacheDataDelegate(DeviceHandle Device, PipelineCacheHandle PipelineCache, UIntPtr PDataSize, IntPtr PData);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result MergePipelineCachesDelegate(DeviceHandle Device, PipelineCacheHandle DstCache, uint SrcCacheCount, PipelineCacheHandle PSrcCaches);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateGraphicsPipelinesDelegate(DeviceHandle Device, PipelineCacheHandle PipelineCache, uint CreateInfoCount, GraphicsPipelineCreateInfo PCreateInfos, AllocationCallbacks PAllocator, PipelineHandle PPipelines);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateComputePipelinesDelegate(DeviceHandle Device, PipelineCacheHandle PipelineCache, uint CreateInfoCount, ComputePipelineCreateInfo PCreateInfos, AllocationCallbacks PAllocator, PipelineHandle PPipelines);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr DestroyPipelineDelegate(DeviceHandle Device, PipelineHandle Pipeline, AllocationCallbacks PAllocator);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreatePipelineLayoutDelegate(DeviceHandle Device, PipelineLayoutCreateInfo PCreateInfo, AllocationCallbacks PAllocator, PipelineLayoutHandle PPipelineLayout);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr DestroyPipelineLayoutDelegate(DeviceHandle Device, PipelineLayoutHandle PipelineLayout, AllocationCallbacks PAllocator);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateSamplerDelegate(DeviceHandle Device, SamplerCreateInfo PCreateInfo, AllocationCallbacks PAllocator, SamplerHandle PSampler);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr DestroySamplerDelegate(DeviceHandle Device, SamplerHandle Sampler, AllocationCallbacks PAllocator);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateDescriptorSetLayoutDelegate(DeviceHandle Device, DescriptorSetLayoutCreateInfo PCreateInfo, AllocationCallbacks PAllocator, DescriptorSetLayoutHandle PSetLayout);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr DestroyDescriptorSetLayoutDelegate(DeviceHandle Device, DescriptorSetLayoutHandle DescriptorSetLayout, AllocationCallbacks PAllocator);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateDescriptorPoolDelegate(DeviceHandle Device, DescriptorPoolCreateInfo PCreateInfo, AllocationCallbacks PAllocator, DescriptorPoolHandle PDescriptorPool);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr DestroyDescriptorPoolDelegate(DeviceHandle Device, DescriptorPoolHandle DescriptorPool, AllocationCallbacks PAllocator);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result ResetDescriptorPoolDelegate(DeviceHandle Device, DescriptorPoolHandle DescriptorPool, DescriptorPoolResetFlags Flags);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result AllocateDescriptorSetsDelegate(DeviceHandle Device, DescriptorSetAllocateInfo PAllocateInfo, DescriptorSetHandle PDescriptorSets);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result FreeDescriptorSetsDelegate(DeviceHandle Device, DescriptorPoolHandle DescriptorPool, uint DescriptorSetCount, DescriptorSetHandle PDescriptorSets);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr UpdateDescriptorSetsDelegate(DeviceHandle Device, uint DescriptorWriteCount, WriteDescriptorSet PDescriptorWrites, uint DescriptorCopyCount, CopyDescriptorSet PDescriptorCopies);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateFramebufferDelegate(DeviceHandle Device, FramebufferCreateInfo PCreateInfo, AllocationCallbacks PAllocator, FramebufferHandle PFramebuffer);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr DestroyFramebufferDelegate(DeviceHandle Device, FramebufferHandle Framebuffer, AllocationCallbacks PAllocator);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateRenderPassDelegate(DeviceHandle Device, RenderPassCreateInfo PCreateInfo, AllocationCallbacks PAllocator, RenderPassHandle PRenderPass);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr DestroyRenderPassDelegate(DeviceHandle Device, RenderPassHandle RenderPass, AllocationCallbacks PAllocator);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr GetRenderAreaGranularityDelegate(DeviceHandle Device, RenderPassHandle RenderPass, Extent2D PGranularity);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateCommandPoolDelegate(DeviceHandle Device, CommandPoolCreateInfo PCreateInfo, AllocationCallbacks PAllocator, CommandPoolHandle PCommandPool);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr DestroyCommandPoolDelegate(DeviceHandle Device, CommandPoolHandle CommandPool, AllocationCallbacks PAllocator);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result ResetCommandPoolDelegate(DeviceHandle Device, CommandPoolHandle CommandPool, CommandPoolResetFlags Flags);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result AllocateCommandBuffersDelegate(DeviceHandle Device, CommandBufferAllocateInfo PAllocateInfo, CommandBufferHandle PCommandBuffers);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr FreeCommandBuffersDelegate(DeviceHandle Device, CommandPoolHandle CommandPool, uint CommandBufferCount, CommandBufferHandle PCommandBuffers);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result BeginCommandBufferDelegate(CommandBufferHandle CommandBuffer, CommandBufferBeginInfo PBeginInfo);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result EndCommandBufferDelegate(CommandBufferHandle CommandBuffer);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result ResetCommandBufferDelegate(CommandBufferHandle CommandBuffer, CommandBufferResetFlags Flags);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdBindPipelineDelegate(CommandBufferHandle CommandBuffer, PipelineBindPoint PipelineBindPoint, PipelineHandle Pipeline);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdSetViewportDelegate(CommandBufferHandle CommandBuffer, uint FirstViewport, uint ViewportCount, Viewport PViewports);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdSetScissorDelegate(CommandBufferHandle CommandBuffer, uint FirstScissor, uint ScissorCount, Rect2D PScissors);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdSetLineWidthDelegate(CommandBufferHandle CommandBuffer, float LineWidth);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdSetDepthBiasDelegate(CommandBufferHandle CommandBuffer, float DepthBiasConstantFactor, float DepthBiasClamp, float DepthBiasSlopeFactor);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdSetBlendConstantsDelegate(CommandBufferHandle CommandBuffer, float BlendConstants);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdSetDepthBoundsDelegate(CommandBufferHandle CommandBuffer, float MinDepthBounds, float MaxDepthBounds);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdSetStencilCompareMaskDelegate(CommandBufferHandle CommandBuffer, StencilFaceFlags FaceMask, uint CompareMask);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdSetStencilWriteMaskDelegate(CommandBufferHandle CommandBuffer, StencilFaceFlags FaceMask, uint WriteMask);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdSetStencilReferenceDelegate(CommandBufferHandle CommandBuffer, StencilFaceFlags FaceMask, uint Reference);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdBindDescriptorSetsDelegate(CommandBufferHandle CommandBuffer, PipelineBindPoint PipelineBindPoint, PipelineLayoutHandle Layout, uint FirstSet, uint DescriptorSetCount, DescriptorSetHandle PDescriptorSets, uint DynamicOffsetCount, uint PDynamicOffsets);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdBindIndexBufferDelegate(CommandBufferHandle CommandBuffer, BufferHandle Buffer, ulong Offset, IndexType IndexType);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdBindVertexBuffersDelegate(CommandBufferHandle CommandBuffer, uint FirstBinding, uint BindingCount, BufferHandle PBuffers, ulong POffsets);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdDrawDelegate(CommandBufferHandle CommandBuffer, uint VertexCount, uint InstanceCount, uint FirstVertex, uint FirstInstance);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdDrawIndexedDelegate(CommandBufferHandle CommandBuffer, uint IndexCount, uint InstanceCount, uint FirstIndex, int VertexOffset, uint FirstInstance);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdDrawIndirectDelegate(CommandBufferHandle CommandBuffer, BufferHandle Buffer, ulong Offset, uint DrawCount, uint Stride);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdDrawIndexedIndirectDelegate(CommandBufferHandle CommandBuffer, BufferHandle Buffer, ulong Offset, uint DrawCount, uint Stride);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdDispatchDelegate(CommandBufferHandle CommandBuffer, uint X, uint Y, uint Z);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdDispatchIndirectDelegate(CommandBufferHandle CommandBuffer, BufferHandle Buffer, ulong Offset);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdCopyBufferDelegate(CommandBufferHandle CommandBuffer, BufferHandle SrcBuffer, BufferHandle DstBuffer, uint RegionCount, BufferCopy PRegions);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdCopyImageDelegate(CommandBufferHandle CommandBuffer, ImageHandle SrcImage, ImageLayout SrcImageLayout, ImageHandle DstImage, ImageLayout DstImageLayout, uint RegionCount, ImageCopy PRegions);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdBlitImageDelegate(CommandBufferHandle CommandBuffer, ImageHandle SrcImage, ImageLayout SrcImageLayout, ImageHandle DstImage, ImageLayout DstImageLayout, uint RegionCount, ImageBlit PRegions, Filter Filter);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdCopyBufferToImageDelegate(CommandBufferHandle CommandBuffer, BufferHandle SrcBuffer, ImageHandle DstImage, ImageLayout DstImageLayout, uint RegionCount, BufferImageCopy PRegions);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdCopyImageToBufferDelegate(CommandBufferHandle CommandBuffer, ImageHandle SrcImage, ImageLayout SrcImageLayout, BufferHandle DstBuffer, uint RegionCount, BufferImageCopy PRegions);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdUpdateBufferDelegate(CommandBufferHandle CommandBuffer, BufferHandle DstBuffer, ulong DstOffset, ulong DataSize, IntPtr PData);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdFillBufferDelegate(CommandBufferHandle CommandBuffer, BufferHandle DstBuffer, ulong DstOffset, ulong Size, uint Data);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdClearColorImageDelegate(CommandBufferHandle CommandBuffer, ImageHandle Image, ImageLayout ImageLayout, ClearColorValue PColor, uint RangeCount, ImageSubresourceRange PRanges);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdClearDepthStencilImageDelegate(CommandBufferHandle CommandBuffer, ImageHandle Image, ImageLayout ImageLayout, ClearDepthStencilValue PDepthStencil, uint RangeCount, ImageSubresourceRange PRanges);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdClearAttachmentsDelegate(CommandBufferHandle CommandBuffer, uint AttachmentCount, ClearAttachment PAttachments, uint RectCount, ClearRect PRects);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdResolveImageDelegate(CommandBufferHandle CommandBuffer, ImageHandle SrcImage, ImageLayout SrcImageLayout, ImageHandle DstImage, ImageLayout DstImageLayout, uint RegionCount, ImageResolve PRegions);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdSetEventDelegate(CommandBufferHandle CommandBuffer, EventHandle Event, PipelineStageFlags StageMask);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdResetEventDelegate(CommandBufferHandle CommandBuffer, EventHandle Event, PipelineStageFlags StageMask);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdWaitEventsDelegate(CommandBufferHandle CommandBuffer, uint EventCount, EventHandle PEvents, PipelineStageFlags SrcStageMask, PipelineStageFlags DstStageMask, uint MemoryBarrierCount, MemoryBarrier PMemoryBarriers, uint BufferMemoryBarrierCount, BufferMemoryBarrier PBufferMemoryBarriers, uint ImageMemoryBarrierCount, ImageMemoryBarrier PImageMemoryBarriers);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdPipelineBarrierDelegate(CommandBufferHandle CommandBuffer, PipelineStageFlags SrcStageMask, PipelineStageFlags DstStageMask, DependencyFlags DependencyFlags, uint MemoryBarrierCount, MemoryBarrier PMemoryBarriers, uint BufferMemoryBarrierCount, BufferMemoryBarrier PBufferMemoryBarriers, uint ImageMemoryBarrierCount, ImageMemoryBarrier PImageMemoryBarriers);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdBeginQueryDelegate(CommandBufferHandle CommandBuffer, QueryPoolHandle QueryPool, uint Query, QueryControlFlags Flags);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdEndQueryDelegate(CommandBufferHandle CommandBuffer, QueryPoolHandle QueryPool, uint Query);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdResetQueryPoolDelegate(CommandBufferHandle CommandBuffer, QueryPoolHandle QueryPool, uint FirstQuery, uint QueryCount);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdWriteTimestampDelegate(CommandBufferHandle CommandBuffer, PipelineStageFlags PipelineStage, QueryPoolHandle QueryPool, uint Query);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdCopyQueryPoolResultsDelegate(CommandBufferHandle CommandBuffer, QueryPoolHandle QueryPool, uint FirstQuery, uint QueryCount, BufferHandle DstBuffer, ulong DstOffset, ulong Stride, QueryResultFlags Flags);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdPushConstantsDelegate(CommandBufferHandle CommandBuffer, PipelineLayoutHandle Layout, ShaderStageFlags StageFlags, uint Offset, uint Size, IntPtr PValues);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdBeginRenderPassDelegate(CommandBufferHandle CommandBuffer, RenderPassBeginInfo PRenderPassBegin, SubpassContents Contents);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdNextSubpassDelegate(CommandBufferHandle CommandBuffer, SubpassContents Contents);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdEndRenderPassDelegate(CommandBufferHandle CommandBuffer);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdExecuteCommandsDelegate(CommandBufferHandle CommandBuffer, uint CommandBufferCount, CommandBufferHandle PCommandBuffers);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateAndroidSurfaceKhrDelegate(InstanceHandle Instance, AndroidSurfaceCreateInfoKhr PCreateInfo, AllocationCallbacks PAllocator, SurfaceKhrHandle PSurface);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result GetPhysicalDeviceDisplayPropertiesKhrDelegate(PhysicalDeviceHandle PhysicalDevice, uint PPropertyCount, DisplayPropertiesKhr PProperties);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result GetPhysicalDeviceDisplayPlanePropertiesKhrDelegate(PhysicalDeviceHandle PhysicalDevice, uint PPropertyCount, DisplayPlanePropertiesKhr PProperties);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result GetDisplayPlaneSupportedDisplaysKhrDelegate(PhysicalDeviceHandle PhysicalDevice, uint PlaneIndex, uint PDisplayCount, DisplayKhrHandle PDisplays);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result GetDisplayModePropertiesKhrDelegate(PhysicalDeviceHandle PhysicalDevice, DisplayKhrHandle Display, uint PPropertyCount, DisplayModePropertiesKhr PProperties);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateDisplayModeKhrDelegate(PhysicalDeviceHandle PhysicalDevice, DisplayKhrHandle Display, DisplayModeCreateInfoKhr PCreateInfo, AllocationCallbacks PAllocator, DisplayModeKhrHandle PMode);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result GetDisplayPlaneCapabilitiesKhrDelegate(PhysicalDeviceHandle PhysicalDevice, DisplayModeKhrHandle Mode, uint PlaneIndex, DisplayPlaneCapabilitiesKhr PCapabilities);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateDisplayPlaneSurfaceKhrDelegate(InstanceHandle Instance, DisplaySurfaceCreateInfoKhr PCreateInfo, AllocationCallbacks PAllocator, SurfaceKhrHandle PSurface);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateSharedSwapchainsKhrDelegate(DeviceHandle Device, uint SwapchainCount, SwapchainCreateInfoKhr PCreateInfos, AllocationCallbacks PAllocator, SwapchainKhrHandle PSwapchains);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateMirSurfaceKhrDelegate(InstanceHandle Instance, MirSurfaceCreateInfoKhr PCreateInfo, AllocationCallbacks PAllocator, SurfaceKhrHandle PSurface);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate uint GetPhysicalDeviceMirPresentationSupportKhrDelegate(PhysicalDeviceHandle PhysicalDevice, uint QueueFamilyIndex, IntPtr Connection);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr DestroySurfaceKhrDelegate(InstanceHandle Instance, SurfaceKhrHandle Surface, AllocationCallbacks PAllocator);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result GetPhysicalDeviceSurfaceSupportKhrDelegate(PhysicalDeviceHandle PhysicalDevice, uint QueueFamilyIndex, SurfaceKhrHandle Surface, uint PSupported);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result GetPhysicalDeviceSurfaceCapabilitiesKhrDelegate(PhysicalDeviceHandle PhysicalDevice, SurfaceKhrHandle Surface, SurfaceCapabilitiesKhr PSurfaceCapabilities);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result GetPhysicalDeviceSurfaceFormatsKhrDelegate(PhysicalDeviceHandle PhysicalDevice, SurfaceKhrHandle Surface, uint PSurfaceFormatCount, SurfaceFormatKhr PSurfaceFormats);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result GetPhysicalDeviceSurfacePresentModesKhrDelegate(PhysicalDeviceHandle PhysicalDevice, SurfaceKhrHandle Surface, uint PPresentModeCount, PresentModeKhr PPresentModes);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateSwapchainKhrDelegate(DeviceHandle Device, SwapchainCreateInfoKhr PCreateInfo, AllocationCallbacks PAllocator, SwapchainKhrHandle PSwapchain);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr DestroySwapchainKhrDelegate(DeviceHandle Device, SwapchainKhrHandle Swapchain, AllocationCallbacks PAllocator);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result GetSwapchainImagesKhrDelegate(DeviceHandle Device, SwapchainKhrHandle Swapchain, uint PSwapchainImageCount, ImageHandle PSwapchainImages);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result AcquireNextImageKhrDelegate(DeviceHandle Device, SwapchainKhrHandle Swapchain, ulong Timeout, SemaphoreHandle Semaphore, FenceHandle Fence, uint PImageIndex);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result QueuePresentKhrDelegate(QueueHandle Queue, PresentInfoKhr PPresentInfo);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateWaylandSurfaceKhrDelegate(InstanceHandle Instance, WaylandSurfaceCreateInfoKhr PCreateInfo, AllocationCallbacks PAllocator, SurfaceKhrHandle PSurface);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate uint GetPhysicalDeviceWaylandPresentationSupportKhrDelegate(PhysicalDeviceHandle PhysicalDevice, uint QueueFamilyIndex, IntPtr Display);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateWin32SurfaceKhrDelegate(InstanceHandle Instance, Win32SurfaceCreateInfoKhr PCreateInfo, AllocationCallbacks PAllocator, SurfaceKhrHandle PSurface);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate uint GetPhysicalDeviceWin32PresentationSupportKhrDelegate(PhysicalDeviceHandle PhysicalDevice, uint QueueFamilyIndex);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateXlibSurfaceKhrDelegate(InstanceHandle Instance, XlibSurfaceCreateInfoKhr PCreateInfo, AllocationCallbacks PAllocator, SurfaceKhrHandle PSurface);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate uint GetPhysicalDeviceXlibPresentationSupportKhrDelegate(PhysicalDeviceHandle PhysicalDevice, uint QueueFamilyIndex, IntPtr Dpy, IntPtr VisualID);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateXcbSurfaceKhrDelegate(InstanceHandle Instance, XcbSurfaceCreateInfoKhr PCreateInfo, AllocationCallbacks PAllocator, SurfaceKhrHandle PSurface);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate uint GetPhysicalDeviceXcbPresentationSupportKhrDelegate(PhysicalDeviceHandle PhysicalDevice, uint QueueFamilyIndex, IntPtr Connection, IntPtr VisualId);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result CreateDebugReportCallbackExtDelegate(InstanceHandle Instance, DebugReportCallbackCreateInfoExt PCreateInfo, AllocationCallbacks PAllocator, DebugReportCallbackExtHandle PCallback);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr DestroyDebugReportCallbackExtDelegate(InstanceHandle Instance, DebugReportCallbackExtHandle Callback, AllocationCallbacks PAllocator);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr DebugReportMessageExtDelegate(InstanceHandle Instance, DebugReportFlagsExt Flags, DebugReportObjectTypeExt ObjectType, ulong Handle, UIntPtr Location, int MessageCode, byte PLayerPrefix, byte PMessage);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result DebugMarkerSetObjectNameExtDelegate(DeviceHandle Device, DebugMarkerObjectNameInfoExt PNameInfo);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate Result DebugMarkerSetObjectTagExtDelegate(DeviceHandle Device, DebugMarkerObjectTagInfoExt PTagInfo);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdDebugMarkerBeginExtDelegate(CommandBufferHandle CommandBuffer, DebugMarkerMarkerInfoExt PMarkerInfo);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdDebugMarkerEndExtDelegate(CommandBufferHandle CommandBuffer);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate IntPtr CmdDebugMarkerInsertExtDelegate(CommandBufferHandle CommandBuffer, DebugMarkerMarkerInfoExt PMarkerInfo);
    }
}