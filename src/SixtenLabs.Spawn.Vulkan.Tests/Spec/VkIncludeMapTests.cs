using Xunit;
using FluentAssertions;

namespace SixtenLabs.Spawn.Vulkan.Tests.Spec
{
	public class VkIncludeMapTests : IClassFixture<SpecFixture>
	{
		public VkIncludeMapTests(SpecFixture fixture)
		{
			Fixture = fixture;
		}

		[Fact]
		public void VkRegistry_VkTypeIncludes_Mapped()
		{
			var subject = Fixture.VkRegistry;

			subject.Includes.Should().HaveCount(8);
		}

		[Theory]
		[InlineData(0, "vk_platform", "include")]
		[InlineData(1, "vulkan.h", "include")]
		[InlineData(2, "X11/Xlib.h", "include")]
		[InlineData(3, "android/native_window.h", "include")]
		[InlineData(4, "mir_toolkit/client_types.h", "include")]
		[InlineData(5, "wayland-client.h", "include")]
		[InlineData(6, "windows.h", "include")]
		[InlineData(7, "xcb/xcb.h", "include")]
		public void VkRegistry_TypeInclude_MappedCorrectly(int index, string name, string category)
		{
			var subject = Fixture.VkRegistry;

			subject.Includes[index].Name.Should().Be(name);
			subject.Includes[index].Category.Should().Be(category);
		}

		private SpecFixture Fixture { get; set; }
	}
}
