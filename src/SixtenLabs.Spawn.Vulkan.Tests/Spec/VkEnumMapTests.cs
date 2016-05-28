using Xunit;
using FluentAssertions;

using System.Linq;

namespace SixtenLabs.Spawn.Vulkan.Tests.Spec
{
	public class VkEnumMapTests : IClassFixture<SpecFixture>
	{
		public VkEnumMapTests(SpecFixture fixture)
		{
			Fixture = fixture;
		}

		[Fact]
		public void VkRegistry_VkEnums_Mapped()
		{
			var subject = Fixture.VkRegistry;

			subject.Enums.Should().HaveCount(74);
		}

		[Theory]
		[InlineData("VkImageLayout", "enum", false, 9, null)]
		[InlineData("VkAttachmentLoadOp", "enum", false, 3, null)]
		[InlineData("VkAttachmentStoreOp", "enum", false, 2, null)]
		[InlineData("VkCullModeFlagBits", "bitmask", true, 4, null)]
		[InlineData("VkImageLayout", "enum", false, 9, null)]
		[InlineData("VkStructureType", "enum", false, 49, "Structure type enumerant")]
		public void VkRegistry_VkEnums_MappedCorrectly(string name, string type, bool isFlags, int valuesCount, string comment)
		{
			var subject = Fixture.VkRegistry.Enums.Where(x => x.Name == name).FirstOrDefault();

			subject.Type.Should().Be(type);
			subject.IsFlags.Should().Be(isFlags);
			subject.Values.Count.Should().Be(valuesCount);
			subject.Comment.Should().Be(comment);
		}

		[Theory]
		[InlineData("VkImageLayout", 0, "VK_IMAGE_LAYOUT_UNDEFINED", "0", null, "Implicit layout an image is when its contents are undefined due to various reasons (e.g. right after creation)")]
		[InlineData("VkCullModeFlagBits", 2, "VK_CULL_MODE_BACK_BIT", null, "1", null)]
		public void VkRegistry_VkEnumValues_MappedCorrectly(string name, int valueIndex, string valueName, string value, string bitpos, string comment)
		{
			var subject = Fixture.VkRegistry.Enums.Where(x => x.Name == name).FirstOrDefault();

			subject.Values[valueIndex].Name.Should().Be(valueName);
			subject.Values[valueIndex].Value.Should().Be(value);
			subject.Values[valueIndex].BitPos.Should().Be(bitpos);
			subject.Values[valueIndex].Comment.Should().Be(comment);
		}

		private SpecFixture Fixture { get; set; }
	}
}
