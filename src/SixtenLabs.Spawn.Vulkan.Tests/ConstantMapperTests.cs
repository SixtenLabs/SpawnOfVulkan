using Xunit;
using FluentAssertions;
using NSubstitute;

using SixtenLabs.Spawn.CSharp;
using SixtenLabs.Spawn.Vulkan.Spec;

namespace SixtenLabs.Spawn.Vulkan.Tests
{
  public class ConstantMapperTests : IClassFixture<SpecFixture>
  {
    public ConstantMapperTests(SpecFixture fixture)
    {
      Fixture = fixture;
    }

    private SpecFixture Fixture { get; set; }

    private VkConstant SubjectUnderTest()
    {
      return Fixture.VkRegistry.Constants;
    }

    [Fact]
    public void Constants()
    {
      var subject = SubjectUnderTest();

      var map = Fixture.SpecMapper.Map<ClassDefinition>(subject);

      map.Should().NotBeNull();
      map.FieldDefinitions.Should().HaveCount(15);
    }
  }
}
