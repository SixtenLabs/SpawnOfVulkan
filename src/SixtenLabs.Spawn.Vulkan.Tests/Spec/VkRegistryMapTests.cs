using Xunit;
using FluentAssertions;

namespace SixtenLabs.Spawn.Vulkan.Tests
{
	public class VkRegistryMapTests : IClassFixture<SpecFixture>
	{
		public VkRegistryMapTests(SpecFixture fixture)
		{
			Fixture = fixture;
		}

		[Fact]
		public void VkRegistry_Comments_Mapped()
		{
			var subject = Fixture.VkRegistry;

			subject.Comments.Should().NotBeNull();
		}

		private SpecFixture Fixture { get; set; }
	}
}
