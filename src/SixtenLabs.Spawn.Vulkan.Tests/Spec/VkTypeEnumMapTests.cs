using Xunit;
using FluentAssertions;

namespace SixtenLabs.Spawn.Vulkan.Tests.Spec
{
	public class VkTypeEnumMapTests : IClassFixture<SpecFixture>
	{
		public VkTypeEnumMapTests(SpecFixture fixture)
		{
			Fixture = fixture;
		}

		[Fact]
		public void VkRegistry_TypesEnums_Mapped()
		{
			var subject = Fixture.VkRegistry;

			subject.TypeEnums.Should().HaveCount(95);
		}

		[Theory]
		[InlineData(0, "VkAttachmentLoadOp")]
		[InlineData(1, "VkAttachmentStoreOp")]
		[InlineData(2, "VkBlendFactor")]
		[InlineData(3, "VkBlendOp")]
		[InlineData(4, "VkBorderColor")]
		[InlineData(5, "VkFramebufferCreateFlagBits")]
		[InlineData(6, "VkQueryPoolCreateFlagBits")]
		[InlineData(7, "VkRenderPassCreateFlagBits")]
		[InlineData(8, "VkSamplerCreateFlagBits")]
		[InlineData(9, "VkPipelineCacheHeaderVersion")]

		[InlineData(10, "VkPipelineLayoutCreateFlagBits")]
		[InlineData(11, "VkPipelineCacheCreateFlagBits")]
		[InlineData(12, "VkPipelineDepthStencilStateCreateFlagBits")]
		[InlineData(13, "VkPipelineDynamicStateCreateFlagBits")]
		[InlineData(14, "VkPipelineColorBlendStateCreateFlagBits")]
		[InlineData(15, "VkPipelineMultisampleStateCreateFlagBits")]
		[InlineData(16, "VkPipelineRasterizationStateCreateFlagBits")]
		[InlineData(17, "VkPipelineViewportStateCreateFlagBits")]
		[InlineData(18, "VkPipelineTessellationStateCreateFlagBits")]
		[InlineData(19, "VkPipelineInputAssemblyStateCreateFlagBits")]

		[InlineData(20, "VkPipelineVertexInputStateCreateFlagBits")]
		[InlineData(21, "VkPipelineShaderStageCreateFlagBits")]
		[InlineData(22, "VkDescriptorSetLayoutCreateFlagBits")]
		[InlineData(23, "VkBufferViewCreateFlagBits")]
		[InlineData(24, "VkInstanceCreateFlagBits")]
		[InlineData(25, "VkDeviceQueueCreateFlagBits")]
		[InlineData(26, "VkBufferCreateFlagBits")]
		[InlineData(27, "VkBufferUsageFlagBits")]
		[InlineData(28, "VkColorComponentFlagBits")]
		[InlineData(29, "VkComponentSwizzle")]

		[InlineData(30, "VkCommandPoolCreateFlagBits")]
		[InlineData(31, "VkCommandPoolResetFlagBits")]
		[InlineData(32, "VkCommandBufferResetFlagBits")]
		[InlineData(33, "VkCommandBufferLevel")]
		[InlineData(34, "VkCommandBufferUsageFlagBits")]
		[InlineData(35, "VkCompareOp")]
		[InlineData(36, "VkCullModeFlagBits")]
		[InlineData(37, "VkDescriptorType")]
		[InlineData(38, "VkDeviceCreateFlagBits")]
		[InlineData(39, "VkDynamicState")]

		[InlineData(40, "VkFenceCreateFlagBits")]
		[InlineData(41, "VkPolygonMode")]
		[InlineData(42, "VkFormat")]
		[InlineData(43, "VkFormatFeatureFlagBits")]
		[InlineData(44, "VkFrontFace")]
		[InlineData(45, "VkImageAspectFlagBits")]
		[InlineData(46, "VkImageCreateFlagBits")]
		[InlineData(47, "VkImageLayout")]
		[InlineData(48, "VkImageTiling")]
		[InlineData(49, "VkImageType")]

		[InlineData(50, "VkImageUsageFlagBits")]
		[InlineData(51, "VkImageViewType")]
		[InlineData(52, "VkSharingMode")]
		[InlineData(53, "VkIndexType")]
		[InlineData(54, "VkLogicOp")]
		[InlineData(55, "VkMemoryHeapFlagBits")]
		[InlineData(56, "VkAccessFlagBits")]
		[InlineData(57, "VkMemoryPropertyFlagBits")]
		[InlineData(58, "VkPhysicalDeviceType")]
		[InlineData(59, "VkPipelineBindPoint")]

		[InlineData(60, "VkPipelineCreateFlagBits")]
		[InlineData(61, "VkPrimitiveTopology")]
		[InlineData(62, "VkQueryControlFlagBits")]
		[InlineData(63, "VkQueryPipelineStatisticFlagBits")]
		[InlineData(64, "VkQueryResultFlagBits")]
		[InlineData(65, "VkQueryType")]
		[InlineData(66, "VkQueueFlagBits")]
		[InlineData(67, "VkSubpassContents")]
		[InlineData(68, "VkResult")]
		[InlineData(69, "VkShaderStageFlagBits")]

		[InlineData(70, "VkSparseMemoryBindFlagBits")]
		[InlineData(71, "VkStencilFaceFlagBits")]
		[InlineData(72, "VkStencilOp")]
		[InlineData(73, "VkStructureType")]
		[InlineData(74, "VkSystemAllocationScope")]
		[InlineData(75, "VkInternalAllocationType")]
		[InlineData(76, "VkSamplerAddressMode")]
		[InlineData(77, "VkFilter")]
		[InlineData(78, "VkSamplerMipmapMode")]
		[InlineData(79, "VkVertexInputRate")]

		[InlineData(80, "VkPipelineStageFlagBits")]
		[InlineData(81, "VkSparseImageFormatFlagBits")]
		[InlineData(82, "VkSampleCountFlagBits")]
		[InlineData(83, "VkAttachmentDescriptionFlagBits")]
		[InlineData(84, "VkDescriptorPoolCreateFlagBits")]
		[InlineData(85, "VkDependencyFlagBits")]
		[InlineData(86, "VkColorSpaceKHR")]
		[InlineData(87, "VkCompositeAlphaFlagBitsKHR")]
		[InlineData(88, "VkDisplayPlaneAlphaFlagBitsKHR")]
		[InlineData(89, "VkPresentModeKHR")]

		[InlineData(90, "VkSurfaceTransformFlagBitsKHR")]
		[InlineData(91, "VkDebugReportFlagBitsEXT")]
		[InlineData(92, "VkDebugReportObjectTypeEXT")]
		[InlineData(93, "VkDebugReportErrorEXT")]
		[InlineData(94, "VkRasterizationOrderAMD")]
		public void VkRegistry_TypeEnums_MappedCorrectly(int index, string name)
		{
			var subject = Fixture.VkRegistry;

			subject.TypeEnums[index].Name.Should().Be(name);
		}

		private SpecFixture Fixture { get; set; }
	}
}
