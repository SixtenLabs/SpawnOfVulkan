using Xunit;
using FluentAssertions;

namespace SixtenLabs.Spawn.Vulkan.Tests.Spec
{
	public class VkTypeDefineMapTests : IClassFixture<SpecFixture>
	{
		public VkTypeDefineMapTests(SpecFixture fixture)
		{
			Fixture = fixture;
		}

		[Fact]
		public void VkRegistry_TypesDefine_Mapped()
		{
			var subject = Fixture.VkRegistry;

			subject.Defines.Should().HaveCount(10);
		}

		[Theory]
		[InlineData(0, "VK_MAKE_VERSION", "#define VK_MAKE_VERSION(major, minor, patch) \\\n    (((major) << 22) | ((minor) << 12) | (patch))")]
		[InlineData(1, "VK_VERSION_MAJOR", "#define VK_VERSION_MAJOR(version) ((uint32_t)(version) >> 22)")]
		[InlineData(2, "VK_VERSION_MINOR", "#define VK_VERSION_MINOR(version) (((uint32_t)(version) >> 12) & 0x3ff)")]
		[InlineData(3, "VK_VERSION_PATCH", "#define VK_VERSION_PATCH(version) ((uint32_t)(version) & 0xfff)")]
		[InlineData(4, "VK_API_VERSION", "// DEPRECATED: This define has been removed. Specific version defines (e.g. VK_API_VERSION_1_0), or the VK_MAKE_VERSION macro, should be used instead.\n//#define VK_API_VERSIONVK_MAKE_VERSION(1, 0, 0)")]
		[InlineData(5, "VK_API_VERSION_1_0", "// Vulkan 1.0 version number\n#define VK_API_VERSION_1_0VK_MAKE_VERSION(1, 0, 0)")]
		[InlineData(6, "VK_HEADER_VERSION", "// Version of this file\n#define VK_HEADER_VERSION 24")]
		[InlineData(7, "VK_DEFINE_HANDLE", "\n#define VK_DEFINE_HANDLE(object) typedef struct object##_T* object;")]
		[InlineData(8, "VK_DEFINE_NON_DISPATCHABLE_HANDLE", "\n#if defined(__LP64__) || defined(_WIN64) || (defined(__x86_64__) && !defined(__ILP32__) ) || defined(_M_X64) || defined(__ia64) || defined (_M_IA64) || defined(__aarch64__) || defined(__powerpc64__)\n        #define VK_DEFINE_NON_DISPATCHABLE_HANDLE(object) typedef struct object##_T *object;\n#else\n        #define VK_DEFINE_NON_DISPATCHABLE_HANDLE(object) typedef uint64_t object;\n#endif\n        ")]
		[InlineData(9, "VK_NULL_HANDLE", "\n#define VK_NULL_HANDLE 0\n        ")]
		public void VkRegistry_TypeDefines_MappedCorrectly(int index, string name, string requires)
		{
			var subject = Fixture.VkRegistry;

			subject.Defines[index].Name.Should().Be(name);
			subject.Defines[index].Value.Should().Be(requires);
		}

		private SpecFixture Fixture { get; set; }
	}
}
