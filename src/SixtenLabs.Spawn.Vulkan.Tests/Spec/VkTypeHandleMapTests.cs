using Xunit;
using FluentAssertions;

namespace SixtenLabs.Spawn.Vulkan.Tests.Spec
{
	public class VkTypeHandleMapTests : IClassFixture<SpecFixture>
	{
		public VkTypeHandleMapTests(SpecFixture fixture)
		{
			Fixture = fixture;
		}

		[Fact]
		public void VkRegistry_TypesHandle_Mapped()
		{
			var subject = Fixture.VkRegistry;

			subject.Handles.Should().HaveCount(30);
		}

		[Theory]
		[InlineData(0, "VkInstance", "VK_DEFINE_HANDLE", null)]
		[InlineData(1, "VkPhysicalDevice", "VK_DEFINE_HANDLE", "VkInstance")]
		[InlineData(2, "VkDevice", "VK_DEFINE_HANDLE", "VkPhysicalDevice")]
		[InlineData(3, "VkQueue", "VK_DEFINE_HANDLE", "VkDevice")]
		[InlineData(4, "VkCommandBuffer", "VK_DEFINE_HANDLE", "VkCommandPool")]
		[InlineData(5, "VkDeviceMemory", "VK_DEFINE_NON_DISPATCHABLE_HANDLE", "VkDevice")]
		[InlineData(6, "VkCommandPool", "VK_DEFINE_NON_DISPATCHABLE_HANDLE", "VkDevice")]
		[InlineData(7, "VkBuffer", "VK_DEFINE_NON_DISPATCHABLE_HANDLE", "VkDevice")]
		[InlineData(8, "VkBufferView", "VK_DEFINE_NON_DISPATCHABLE_HANDLE", "VkDevice")]
		[InlineData(9, "VkImage", "VK_DEFINE_NON_DISPATCHABLE_HANDLE", "VkDevice")]

		[InlineData(10, "VkImageView", "VK_DEFINE_NON_DISPATCHABLE_HANDLE", "VkDevice")]
		[InlineData(11, "VkShaderModule", "VK_DEFINE_NON_DISPATCHABLE_HANDLE", "VkDevice")]
		[InlineData(12, "VkPipeline", "VK_DEFINE_NON_DISPATCHABLE_HANDLE", "VkDevice")]
		[InlineData(13, "VkPipelineLayout", "VK_DEFINE_NON_DISPATCHABLE_HANDLE", "VkDevice")]
		[InlineData(14, "VkSampler", "VK_DEFINE_NON_DISPATCHABLE_HANDLE", "VkDevice")]
		[InlineData(15, "VkDescriptorSet", "VK_DEFINE_NON_DISPATCHABLE_HANDLE", "VkDescriptorPool")]
		[InlineData(16, "VkDescriptorSetLayout", "VK_DEFINE_NON_DISPATCHABLE_HANDLE", "VkDevice")]
		[InlineData(17, "VkDescriptorPool", "VK_DEFINE_NON_DISPATCHABLE_HANDLE", "VkDevice")]
		[InlineData(18, "VkFence", "VK_DEFINE_NON_DISPATCHABLE_HANDLE", "VkDevice")]
		[InlineData(19, "VkSemaphore", "VK_DEFINE_NON_DISPATCHABLE_HANDLE", "VkDevice")]

		[InlineData(20, "VkEvent", "VK_DEFINE_NON_DISPATCHABLE_HANDLE", "VkDevice")]
		[InlineData(21, "VkQueryPool", "VK_DEFINE_NON_DISPATCHABLE_HANDLE", "VkDevice")]
		[InlineData(22, "VkFramebuffer", "VK_DEFINE_NON_DISPATCHABLE_HANDLE", "VkDevice")]
		[InlineData(23, "VkRenderPass", "VK_DEFINE_NON_DISPATCHABLE_HANDLE", "VkDevice")]
		[InlineData(24, "VkPipelineCache", "VK_DEFINE_NON_DISPATCHABLE_HANDLE", "VkDevice")]
		[InlineData(25, "VkDisplayKHR", "VK_DEFINE_NON_DISPATCHABLE_HANDLE", null)]
		[InlineData(26, "VkDisplayModeKHR", "VK_DEFINE_NON_DISPATCHABLE_HANDLE", "VkPhysicalDevice,VkDisplayKHR")]
		[InlineData(27, "VkSurfaceKHR", "VK_DEFINE_NON_DISPATCHABLE_HANDLE", "VkInstance")]
		[InlineData(28, "VkSwapchainKHR", "VK_DEFINE_NON_DISPATCHABLE_HANDLE", "VkSurfaceKHR")]
		[InlineData(29, "VkDebugReportCallbackEXT", "VK_DEFINE_NON_DISPATCHABLE_HANDLE", "VkInstance")]
		public void VkRegistry_TypeHandles_MappedCorrectly(int index, string name, string type, string parent)
		{
			var subject = Fixture.VkRegistry;

			subject.Handles[index].Name.Should().Be(name);
			subject.Handles[index].Type.Should().Be(type);
			subject.Handles[index].Parent.Should().Be(parent);
		}

		private SpecFixture Fixture { get; set; }
	}
}
