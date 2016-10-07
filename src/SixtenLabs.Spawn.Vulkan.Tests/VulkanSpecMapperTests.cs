using Xunit;
using FluentAssertions;
using NSubstitute;
using AutoMapper;
using SixtenLabs.Spawn.Vulkan.Spec;

namespace SixtenLabs.Spawn.Vulkan.Tests
{
  public class VulkanSpecMapperTests : IClassFixture<SpecFixture>
  {
    public VulkanSpecMapperTests(SpecFixture fixture)
    {
      Fixture = fixture;
    }

    private SpecFixture Fixture { get; set; }

    private ISpecMapper<VkRegistry> SubjectUnderTest()
    {
      return Fixture.VulkanSpecMapper;
    }

    [Fact]
    public void xx()
    {
      var subject = SubjectUnderTest();

      subject.MapSpecTypes(Fixture.SpecMapper, Fixture.VkRegistry);
    }

    private IDefinitionDictionary MockDefinitionDictionary { get; set; }
  }
}
