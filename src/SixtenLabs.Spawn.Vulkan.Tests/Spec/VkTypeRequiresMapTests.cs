using Xunit;
using FluentAssertions;

namespace SixtenLabs.Spawn.Vulkan.Tests.Spec
{
	public class VkTypeRequiresMapTests : IClassFixture<SpecFixture>
	{
		public VkTypeRequiresMapTests(SpecFixture fixture)
		{
			Fixture = fixture;
		}

		[Fact]
		public void VkRegistry_TypesRequires_Mapped()
		{
			var subject = Fixture.VkRegistry;

			subject.Requires.Should().HaveCount(55);
		}

		[Theory]
		[InlineData(0, "Display", "X11/Xlib.h")]
		[InlineData(1, "VisualID", "X11/Xlib.h")]
		[InlineData(2, "Window", "X11/Xlib.h")]
		[InlineData(3, "ANativeWindow", "android/native_window.h")]
		[InlineData(4, "MirConnection", "mir_toolkit/client_types.h")]
		[InlineData(5, "MirSurface", "mir_toolkit/client_types.h")]
		[InlineData(6, "wl_display", "wayland-client.h")]
		[InlineData(7, "wl_surface", "wayland-client.h")]
		[InlineData(8, "HINSTANCE", "windows.h")]
		[InlineData(9, "HWND", "windows.h")]
		[InlineData(10, "xcb_connection_t", "xcb/xcb.h")]
		[InlineData(11, "xcb_visualid_t", "xcb/xcb.h")]
		[InlineData(12, "xcb_window_t", "xcb/xcb.h")]
		//<!-- Basic C types, pulled in via vk_platform.h -->
		[InlineData(13, "void", "vk_platform")]
		[InlineData(14, "char", "vk_platform")]
		[InlineData(15, "float", "vk_platform")]
		[InlineData(16, "uint8_t", "vk_platform")]
		[InlineData(17, "uint32_t", "vk_platform")]
		[InlineData(18, "uint64_t", "vk_platform")]
		[InlineData(19, "int32_t", "vk_platform")]
		[InlineData(20, "size_t", "vk_platform")]
		public void VkRegistry_Requires_MappedCorrectly(int index, string name, string requires)
		{
			var subject = Fixture.VkRegistry;

			subject.Requires[index].Name.Should().Be(name);
			subject.Requires[index].Requires.Should().Be(requires);
		}

		private SpecFixture Fixture { get; set; }
	}
}
