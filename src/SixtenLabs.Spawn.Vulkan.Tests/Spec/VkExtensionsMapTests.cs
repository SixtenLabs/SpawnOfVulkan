using Xunit;
using FluentAssertions;

using System.Linq;

namespace SixtenLabs.Spawn.Vulkan.Tests.Spec
{
	public class VkExtensionsMapTests : IClassFixture<SpecFixture>
	{
		public VkExtensionsMapTests(SpecFixture fixture)
		{
			Fixture = fixture;
		}

		[Fact]
		public void VkRegistry_VkExtensions_Mapped()
		{
			var subject = Fixture.VkRegistry;

			subject.Extensions.Should().HaveCount(23);
		}

		[Theory]
		[InlineData("VK_KHR_surface", "1", "vulkan", null, null, null, 5, 0, 5, 0)]
		[InlineData("VK_KHR_swapchain", "2", "vulkan", null, null, null, 7, 0, 5, 0)]
		[InlineData("VK_KHR_display", "3", "vulkan", null, null, null, 4, 9, 7, 0)]
		[InlineData("VK_KHR_display_swapchain", "4", "vulkan", null, null, null, 4, 1, 1, 0)]
		[InlineData("VK_KHR_xlib_surface", "5", "vulkan", "VK_USE_PLATFORM_XLIB_KHR", null, null, 3, 2, 2, 0)]
		[InlineData("VK_KHR_xcb_surface", "6", "vulkan", "VK_USE_PLATFORM_XCB_KHR", null, null, 3, 2, 2, 0)]
		[InlineData("VK_KHR_wayland_surface", "7", "vulkan", "VK_USE_PLATFORM_WAYLAND_KHR", null, null, 3, 2, 2, 0)]
		[InlineData("VK_KHR_mir_surface", "8", "vulkan", "VK_USE_PLATFORM_MIR_KHR", null, null, 3, 2, 2, 0)]
		[InlineData("VK_KHR_android_surface", "9", "vulkan", "VK_USE_PLATFORM_ANDROID_KHR", null, null, 3, 2, 1, 0)]
		[InlineData("VK_KHR_win32_surface", "10", "vulkan", "VK_USE_PLATFORM_WIN32_KHR", null, null, 3, 2, 2, 0)]
		[InlineData("VK_ANDROID_native_buffer", "11", "disabled", null, null, null, 3, 0, 0, 0)]
		[InlineData("VK_EXT_debug_report", "12", "vulkan", null, "Google, Inc.", "Courtney Goeltzenleuchter @courtney", 5, 2, 3, 0)]
		[InlineData("VK_NV_glsl_shader", "13", "vulkan", null, "NVIDIA", "Piers Daniell @pdaniell", 3, 0, 0, 0)]
		[InlineData("VK_NV_extension_1", "14", "disabled", null, "NVIDIA", "Piers Daniell @pdaniell", 3, 0, 0, 0)]
		[InlineData("VK_KHR_sampler_mirror_clamp_to_edge", "15", "vulkan", null, "KHR", "Tobias Hector @tobias", 3, 0, 0, 0)]
		[InlineData("VK_IMG_filter_cubic", "16", "vulkan", null, "IMG", "Tobias Hector @tobias", 4, 0, 0, 14)]
		[InlineData("VK_AMD_extension_1", "17", "disabled", null, "AMD", "Daniel Rakos @aqnuep", 2, 0, 0, 0)]
		[InlineData("VK_AMD_extension_2", "18", "disabled", null, "AMD", "Daniel Rakos @aqnuep", 2, 0, 0, 0)]
		[InlineData("VK_AMD_rasterization_order", "19", "vulkan", null, "AMD", "Daniel Rakos @aqnuep", 3, 2, 0, 0)]
		[InlineData("VK_AMD_extension_4", "20", "disabled", null, "AMD", "Daniel Rakos @aqnuep", 2, 0, 0, 0)]
		[InlineData("VK_AMD_extension_5", "21", "disabled", null, "AMD", "Daniel Rakos @aqnuep", 2, 0, 0, 0)]
		[InlineData("VK_AMD_extension_6", "22", "disabled", null, "AMD", "Daniel Rakos @aqnuep", 2, 0, 0, 0)]
		[InlineData("VK_EXT_debug_marker", "23", "vulkan", null, "Baldur Karlsson", "baldurk@baldurk.org", 5, 3, 5, 0)]
		public void VkRegistry_VkExtensions_MappedCorrectly(string name, string number, string supported, string protect, string author, string contact,
			int enumCount, int typeCount, int commandCount, int usageCount)
		{
			var subject = Fixture.VkRegistry.Extensions.Where(x => x.Name == name).FirstOrDefault();

			subject.Number.Should().Be(number);
			subject.Supported.Should().Be(supported);
			subject.Protect.Should().Be(protect);
			subject.Author.Should().Be(author);
			subject.Contact.Should().Be(contact);
			subject.Enums.Count.Should().Be(enumCount);
			subject.Types.Count.Should().Be(typeCount);
			subject.Commands.Count.Should().Be(commandCount);
			subject.Usages.Count.Should().Be(usageCount);
		}

		[Theory]
		[InlineData("VK_KHR_surface", 0, "VK_KHR_SURFACE_SPEC_VERSION", "25", null, null, null, null, null)]
		[InlineData("VK_KHR_surface", 1, "VK_KHR_SURFACE_EXTENSION_NAME", "\"VK_KHR_surface\"", null, null, null, null, null)]
		[InlineData("VK_KHR_surface", 2, "VK_ERROR_SURFACE_LOST_KHR", null, "0", "VkResult", null, null, "-")]
		[InlineData("VK_KHR_surface", 3, "VK_ERROR_NATIVE_WINDOW_IN_USE_KHR", null, "1", "VkResult", null, null, "-")]
		[InlineData("VK_KHR_surface", 4, "VK_COLORSPACE_SRGB_NONLINEAR_KHR", "VK_COLOR_SPACE_SRGB_NONLINEAR_KHR", null, null, null, null, null)]
		public void VkRegistry_VkExtensionEnums_MappedCorrectly(string extensionName, int valueIndex, string name, string value, string offset, 
			string extends, string bitPos, string comment, string dir)
		{
			var subject = Fixture.VkRegistry.Extensions.Where(x => x.Name == extensionName).FirstOrDefault();

			subject.Enums[valueIndex].Name.Should().Be(name);
			subject.Enums[valueIndex].Value.Should().Be(value);
			subject.Enums[valueIndex].Offset.Should().Be(offset);
			subject.Enums[valueIndex].Extends.Should().Be(extends);
			subject.Enums[valueIndex].BitPos.Should().Be(bitPos);
			subject.Enums[valueIndex].Comment.Should().Be(comment);
			subject.Enums[valueIndex].Dir.Should().Be(dir);
		}

		[Theory]
		[InlineData("VK_KHR_display_swapchain", 0, "VkDisplayPresentInfoKHR")]
		public void VkRegistry_VkExtensionTypes_MappedCorrectly(string extensionName, int valueIndex, string name)
		{
			var subject = Fixture.VkRegistry.Extensions.Where(x => x.Name == extensionName).FirstOrDefault();

			subject.Types[valueIndex].Name.Should().Be(name);
		}

		[Theory]
		[InlineData("VK_KHR_surface", 0, "vkDestroySurfaceKHR")]
		[InlineData("VK_KHR_surface", 1, "vkGetPhysicalDeviceSurfaceSupportKHR")]
		[InlineData("VK_KHR_surface", 2, "vkGetPhysicalDeviceSurfaceCapabilitiesKHR")]
		[InlineData("VK_KHR_surface", 3, "vkGetPhysicalDeviceSurfaceFormatsKHR")]
		[InlineData("VK_KHR_surface", 4, "vkGetPhysicalDeviceSurfacePresentModesKHR")]
		[InlineData("VK_KHR_display_swapchain", 0, "vkCreateSharedSwapchainsKHR")]
		public void VkRegistry_VkExtensionCommands_MappedCorrectly(string extensionName, int valueIndex, string name)
		{
			var subject = Fixture.VkRegistry.Extensions.Where(x => x.Name == extensionName).FirstOrDefault();

			subject.Commands[valueIndex].Name.Should().Be(name);
		}

		[Theory]
		[InlineData("VK_IMG_filter_cubic", 0, "vkCmdDraw", null, "Any slink:VkImageView being sampled with ename:VK_FILTER_CUBIC_IMG as a result of this command must: be of a format which supports cubic filtering, as specified by the ename:VK_FORMAT_FEATURE_SAMPLED_IMAGE_FILTER_CUBIC_BIT_IMG flag in sname:VkFormatProperties::pname:linearTilingFeatures (for a linear image) or sname:VkFormatProperties::pname:optimalTilingFeatures(for an optimally tiled image) returned by fname:vkGetPhysicalDeviceFormatProperties")]
		[InlineData("VK_IMG_filter_cubic", 1, "vkCmdDraw", null, "Any slink:VkImageView being sampled with ename:VK_FILTER_CUBIC_IMG as a result of this command mustnot: have an elink:VkImageViewType of ename:VK_IMAGE_VIEW_TYPE_3D, ename:VK_IMAGE_VIEW_TYPE_CUBE, or ename:VK_IMAGE_VIEW_TYPE_CUBE_ARRAY")]
		[InlineData("VK_IMG_filter_cubic", 2, "vkCmdDrawIndexed", null, "Any slink:VkImageView being sampled with ename:VK_FILTER_CUBIC_IMG as a result of this command must: be of a format which supports cubic filtering, as specified by the ename:VK_FORMAT_FEATURE_SAMPLED_IMAGE_FILTER_CUBIC_BIT_IMG flag in sname:VkFormatProperties::pname:linearTilingFeatures (for a linear image) or sname:VkFormatProperties::pname:optimalTilingFeatures(for an optimally tiled image) returned by fname:vkGetPhysicalDeviceFormatProperties")]
		public void VkRegistry_VkExtensionUsages_MappedCorrectly(string extensionName, int valueIndex, string command, string structValue, string value)
		{
			var subject = Fixture.VkRegistry.Extensions.Where(x => x.Name == extensionName).FirstOrDefault();

			subject.Usages[valueIndex].Command.Should().Be(command);
			subject.Usages[valueIndex].Struct.Should().Be(structValue);
			subject.Usages[valueIndex].Value.Should().Be(value);
		}

		private SpecFixture Fixture { get; set; }
	}
}
