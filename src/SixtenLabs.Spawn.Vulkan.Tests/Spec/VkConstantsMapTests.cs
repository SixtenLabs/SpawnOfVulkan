using Xunit;
using FluentAssertions;

using System.Linq;

namespace SixtenLabs.Spawn.Vulkan.Tests.Spec
{
	public class VkConstantsMapTests : IClassFixture<SpecFixture>
	{
		public VkConstantsMapTests(SpecFixture fixture)
		{
			Fixture = fixture;
		}

		[Fact]
		public void VkRegistry_VkConstants_Mapped()
		{
			var subject = Fixture.VkRegistry;

			subject.Constants.Should().NotBeNull();
		}

		[Theory]
		[InlineData("API Constants", 15)]
		public void VkRegistry_VkConstants_MappedCorrectly(string name, int valuesCount)
		{
			var subject = Fixture.VkRegistry.Constants;

			subject.Name.Should().Be(name);
			subject.Values.Count.Should().Be(valuesCount);
		}

		[Theory]
		[InlineData("VK_MAX_PHYSICAL_DEVICE_NAME_SIZE", "256")]
		[InlineData("VK_UUID_SIZE", "16")]
		[InlineData("VK_MAX_EXTENSION_NAME_SIZE", "256")]
		[InlineData("VK_MAX_DESCRIPTION_SIZE", "256")]
		[InlineData("VK_MAX_MEMORY_TYPES", "32")]
		[InlineData("VK_MAX_MEMORY_HEAPS", "16")]
		[InlineData("VK_LOD_CLAMP_NONE", "1000.0f")]
		[InlineData("VK_REMAINING_MIP_LEVELS", "(~0U)")]
		[InlineData("VK_REMAINING_ARRAY_LAYERS", "(~0U)")]
		[InlineData("VK_WHOLE_SIZE", "(~0ULL)")]
		[InlineData("VK_ATTACHMENT_UNUSED", "(~0U)")]
		[InlineData("VK_TRUE", "1")]
		[InlineData("VK_FALSE", "0")]
		[InlineData("VK_QUEUE_FAMILY_IGNORED", "(~0U)")]
		[InlineData("VK_SUBPASS_EXTERNAL", "(~0U)")]
		public void VkRegistry_VkConstantValues_MappedCorrectly(string name, string value)
		{
			var subject = Fixture.VkRegistry.Constants.Values.Where(x => x.Name == name).FirstOrDefault();

			subject.Value.Should().Be(value);
		}

		private SpecFixture Fixture { get; set; }
	}
}
