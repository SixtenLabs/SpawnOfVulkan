using Xunit;
using FluentAssertions;

using System.Linq;

namespace SixtenLabs.Spawn.Vulkan.Tests.Spec
{
	public class VkFeatureMapTests : IClassFixture<SpecFixture>
	{
		public VkFeatureMapTests(SpecFixture fixture)
		{
			Fixture = fixture;
		}

		[Fact]
		public void VkRegistry_Feature_Mapped()
		{
			var subject = Fixture.VkRegistry;

			subject.Feature.Should().NotBeNull();
			subject.Feature.Api.Should().Be("vulkan");
			subject.Feature.Name.Should().Be("VK_VERSION_1_0");
			subject.Feature.Number.Should().Be("1.0");
		}

		[Fact]
		public void VkRegistry_VkFeatureRequires_Mapped()
		{
			var subject = Fixture.VkRegistry;

			subject.Feature.Requires.Should().HaveCount(30);
		}

		[Theory]
		[InlineData("Header boilerplate", 1, 0, 0)]
		[InlineData("API version", 6, 0, 0)]
		[InlineData("API constants", 2, 9, 0)]
		[InlineData("Device initialization", 0, 0, 11)]
		[InlineData("Device commands", 0, 0, 2)]
		[InlineData("Extension discovery commands", 0, 0, 2)]
		[InlineData("Layer discovery commands", 0, 0, 2)]
		[InlineData("queue commands", 0, 0, 4)]
		[InlineData("Memory commands", 0, 0, 7)]
		[InlineData("Memory management API commands", 0, 0, 4)]
		[InlineData("Sparse resource memory management API commands", 0, 0, 3)]
		public void VkRegistry_VkExtensions_MappedCorrectly(string comment, int typeCount, int enumCount, int commandCount)
		{
			var subject = Fixture.VkRegistry.Feature.Requires.Where(x => x.Comment == comment).FirstOrDefault();

			subject.Types.Count.Should().Be(typeCount);
			subject.Enums.Count.Should().Be(enumCount);
			subject.Commands.Count.Should().Be(commandCount);
		}

		private SpecFixture Fixture { get; set; }
	}
}
