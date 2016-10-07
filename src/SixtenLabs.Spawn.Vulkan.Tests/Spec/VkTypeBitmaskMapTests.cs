using Xunit;
using FluentAssertions;

namespace SixtenLabs.Spawn.Vulkan.Tests.Spec
{
	public class VkTypeBitmaskMapTests : IClassFixture<SpecFixture>
	{
		public VkTypeBitmaskMapTests(SpecFixture fixture)
		{
			Fixture = fixture;
		}

		[Fact]
		public void VkRegistry_TypesBitmask_Mapped()
		{
			var subject = Fixture.VkRegistry;

			subject.Bitmasks.Should().HaveCount(73);
		}

		[Theory]
		[InlineData(0, "VkFramebufferCreateFlags", "VkFlags", null)]
		[InlineData(1, "VkQueryPoolCreateFlags", "VkFlags", null)]
		[InlineData(2, "VkRenderPassCreateFlags", "VkFlags", null)]
		[InlineData(3, "VkSamplerCreateFlags", "VkFlags", null)]
		[InlineData(4, "VkPipelineLayoutCreateFlags", "VkFlags", null)]
		[InlineData(5, "VkPipelineCacheCreateFlags", "VkFlags", null)]
		[InlineData(6, "VkPipelineDepthStencilStateCreateFlags", "VkFlags", null)]
		[InlineData(7, "VkPipelineDynamicStateCreateFlags", "VkFlags", null)]
		[InlineData(8, "VkPipelineColorBlendStateCreateFlags", "VkFlags", null)]
		[InlineData(9, "VkPipelineMultisampleStateCreateFlags", "VkFlags", null)]

		[InlineData(10, "VkPipelineRasterizationStateCreateFlags", "VkFlags", null)]
		[InlineData(11, "VkPipelineViewportStateCreateFlags", "VkFlags", null)]
		[InlineData(12, "VkPipelineTessellationStateCreateFlags", "VkFlags", null)]
		[InlineData(13, "VkPipelineInputAssemblyStateCreateFlags", "VkFlags", null)]
		[InlineData(14, "VkPipelineVertexInputStateCreateFlags", "VkFlags", null)]
		[InlineData(15, "VkPipelineShaderStageCreateFlags", "VkFlags", null)]
		[InlineData(16, "VkDescriptorSetLayoutCreateFlags", "VkFlags", null)]
		[InlineData(17, "VkBufferViewCreateFlags", "VkFlags", null)]
		[InlineData(18, "VkInstanceCreateFlags", "VkFlags", null)]
		[InlineData(19, "VkDeviceCreateFlags", "VkFlags", null)]
		[InlineData(20, "VkDeviceQueueCreateFlags", "VkFlags", null)]

		[InlineData(21, "VkQueueFlags", "VkFlags", "VkQueueFlagBits")]
		[InlineData(22, "VkMemoryPropertyFlags", "VkFlags", "VkMemoryPropertyFlagBits")]
		[InlineData(23, "VkMemoryHeapFlags", "VkFlags", "VkMemoryHeapFlagBits")]
		[InlineData(24, "VkAccessFlags", "VkFlags", "VkAccessFlagBits")]
		[InlineData(25, "VkBufferUsageFlags", "VkFlags", "VkBufferUsageFlagBits")]
		[InlineData(26, "VkBufferCreateFlags", "VkFlags", "VkBufferCreateFlagBits")]
		[InlineData(27, "VkShaderStageFlags", "VkFlags", "VkShaderStageFlagBits")]
		[InlineData(28, "VkImageUsageFlags", "VkFlags", "VkImageUsageFlagBits")]
		[InlineData(29, "VkImageCreateFlags", "VkFlags", "VkImageCreateFlagBits")]
		[InlineData(30, "VkImageViewCreateFlags", "VkFlags", null)]

		[InlineData(31, "VkPipelineCreateFlags", "VkFlags", "VkPipelineCreateFlagBits")]
		[InlineData(32, "VkColorComponentFlags", "VkFlags", "VkColorComponentFlagBits")]
		[InlineData(33, "VkFenceCreateFlags", "VkFlags", "VkFenceCreateFlagBits")]
		[InlineData(34, "VkSemaphoreCreateFlags", "VkFlags", null)]
		[InlineData(35, "VkFormatFeatureFlags", "VkFlags", "VkFormatFeatureFlagBits")]
		[InlineData(36, "VkQueryControlFlags", "VkFlags", "VkQueryControlFlagBits")]
		[InlineData(37, "VkQueryResultFlags", "VkFlags", "VkQueryResultFlagBits")]
		[InlineData(38, "VkShaderModuleCreateFlags", "VkFlags", null)]
		[InlineData(39, "VkEventCreateFlags", "VkFlags", null)]
		[InlineData(40, "VkCommandPoolCreateFlags", "VkFlags", "VkCommandPoolCreateFlagBits")]

		[InlineData(41, "VkCommandPoolResetFlags", "VkFlags", "VkCommandPoolResetFlagBits")]
		[InlineData(42, "VkCommandBufferResetFlags", "VkFlags", "VkCommandBufferResetFlagBits")]
		[InlineData(43, "VkCommandBufferUsageFlags", "VkFlags", "VkCommandBufferUsageFlagBits")]
		[InlineData(44, "VkQueryPipelineStatisticFlags", "VkFlags", "VkQueryPipelineStatisticFlagBits")]
		[InlineData(45, "VkMemoryMapFlags", "VkFlags", null)]
		[InlineData(46, "VkImageAspectFlags", "VkFlags", "VkImageAspectFlagBits")]
		[InlineData(47, "VkSparseMemoryBindFlags", "VkFlags", "VkSparseMemoryBindFlagBits")]
		[InlineData(48, "VkSparseImageFormatFlags", "VkFlags", "VkSparseImageFormatFlagBits")]
		[InlineData(49, "VkSubpassDescriptionFlags", "VkFlags", null)]
		[InlineData(50, "VkPipelineStageFlags", "VkFlags", "VkPipelineStageFlagBits")]

		[InlineData(51, "VkSampleCountFlags", "VkFlags", "VkSampleCountFlagBits")]
		[InlineData(52, "VkAttachmentDescriptionFlags", "VkFlags", "VkAttachmentDescriptionFlagBits")]
		[InlineData(53, "VkStencilFaceFlags", "VkFlags", "VkStencilFaceFlagBits")]
		[InlineData(54, "VkCullModeFlags", "VkFlags", "VkCullModeFlagBits")]
		[InlineData(55, "VkDescriptorPoolCreateFlags", "VkFlags", "VkDescriptorPoolCreateFlagBits")]
		[InlineData(56, "VkDescriptorPoolResetFlags", "VkFlags", null)]
		[InlineData(57, "VkDependencyFlags", "VkFlags", "VkDependencyFlagBits")]
		[InlineData(58, "VkCompositeAlphaFlagsKHR", "VkFlags", "VkCompositeAlphaFlagBitsKHR")]
		[InlineData(59, "VkDisplayPlaneAlphaFlagsKHR", "VkFlags", "VkDisplayPlaneAlphaFlagBitsKHR")]
		[InlineData(60, "VkSurfaceTransformFlagsKHR", "VkFlags", "VkSurfaceTransformFlagBitsKHR")]

		[InlineData(61, "VkSwapchainCreateFlagsKHR", "VkFlags", null)]
		[InlineData(62, "VkDisplayModeCreateFlagsKHR", "VkFlags", null)]
		[InlineData(63, "VkDisplaySurfaceCreateFlagsKHR", "VkFlags", null)]
		[InlineData(64, "VkAndroidSurfaceCreateFlagsKHR", "VkFlags", null)]
		[InlineData(65, "VkMirSurfaceCreateFlagsKHR", "VkFlags", null)]
		[InlineData(66, "VkWaylandSurfaceCreateFlagsKHR", "VkFlags", null)]
		[InlineData(67, "VkWin32SurfaceCreateFlagsKHR", "VkFlags", null)]
		[InlineData(68, "VkXlibSurfaceCreateFlagsKHR", "VkFlags", null)]
		[InlineData(69, "VkXcbSurfaceCreateFlagsKHR", "VkFlags", null)]
		[InlineData(70, "VkDebugReportFlagsEXT", "VkFlags", "VkDebugReportFlagBitsEXT")]
		public void VkRegistry_TypeBitmasks_MappedCorrectly(int index, string name, string type, string requires)
		{
			var subject = Fixture.VkRegistry;

			subject.Bitmasks[index].Name.Should().Be(name);
			subject.Bitmasks[index].Type.Should().Be(type);
			subject.Bitmasks[index].Requires.Should().Be(requires);
			subject.Bitmasks[index].Category.Should().Be("bitmask");
		}

		private SpecFixture Fixture { get; set; }
	}
}
