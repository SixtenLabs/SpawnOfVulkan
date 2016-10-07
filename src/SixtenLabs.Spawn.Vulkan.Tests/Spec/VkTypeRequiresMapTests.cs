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

			subject.Requires.Should().HaveCount(60);
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
    [InlineData(10, "HANDLE", "windows.h")]
    [InlineData(11, "SECURITY_ATTRIBUTES", "windows.h")]
    [InlineData(12, "DWORD", "windows.h")]

    [InlineData(13, "xcb_connection_t", "xcb/xcb.h")]
		[InlineData(14, "xcb_visualid_t", "xcb/xcb.h")]
		[InlineData(15, "xcb_window_t", "xcb/xcb.h")]
    //<!-- Basic C types, pulled in via vk_platform.h -->

    [InlineData(16, "void", "vk_platform")]
		[InlineData(17, "char", "vk_platform")]
		[InlineData(18, "float", "vk_platform")]
		[InlineData(19, "uint8_t", "vk_platform")]
		[InlineData(20, "uint32_t", "vk_platform")]
		[InlineData(21, "uint64_t", "vk_platform")]
		[InlineData(22, "int32_t", "vk_platform")]
		[InlineData(23, "size_t", "vk_platform")]
		public void VkRegistry_Requires_MappedCorrectly(int index, string name, string requires)
		{
			var subject = Fixture.VkRegistry;

			subject.Requires[index].Name.Should().Be(name);
			subject.Requires[index].Requires.Should().Be(requires);
		}

		private SpecFixture Fixture { get; set; }
	}
}
