using Xunit;
using FluentAssertions;

using System.Linq;

namespace SixtenLabs.Spawn.Vulkan.Tests.Spec
{
  public class VkFeatureRequireCommandMapTests : IClassFixture<SpecFixture>
  {
    public VkFeatureRequireCommandMapTests(SpecFixture fixture)
    {
      Fixture = fixture;
    }

    [Fact]
    public void VkRegistry_VkFeatureRequire_Mapped()
    {
      var subject = Fixture.VkRegistry;

      subject.Feature.Requires.Should().HaveCount(30);
    }

    [Theory]
    [InlineData("Device initialization", 11)]
    [InlineData("Device commands", 2)]
    [InlineData("Extension discovery commands", 2)]
    [InlineData("Layer discovery commands", 2)]
    public void VkRegistry_VkFeatureRequire_CommandsMappedCorrectly(string name, int count)
    {
      var subject = Fixture.VkRegistry.Feature.Requires.Where(x => x.Comment == name).FirstOrDefault();

      subject.Commands.Count.Should().Be(count);
    }

    [Theory]
    [InlineData("API version", 6)]
    [InlineData("API constants", 2)]
    public void VkRegistry_VkFeatureRequire_TypesMappedCorrectly(string name, int count)
    {
      var subject = Fixture.VkRegistry.Feature.Requires.Where(x => x.Comment == name).FirstOrDefault();

      subject.Types.Count.Should().Be(count);
    }

    [Theory]
    [InlineData("API constants", 9)]
    public void VkRegistry_VkFeatureRequire_EnumsMappedCorrectly(string name, int count)
    {
      var subject = Fixture.VkRegistry.Feature.Requires.Where(x => x.Comment == name).FirstOrDefault();

      subject.Enums.Count.Should().Be(count);
    }

    private SpecFixture Fixture { get; set; }
  }
}
