﻿using Xunit;
using FluentAssertions;

namespace SixtenLabs.Spawn.Vulkan.Tests.Spec
{
	public class VkTypeBaseTypeMapTests : IClassFixture<SpecFixture>
	{
		public VkTypeBaseTypeMapTests(SpecFixture fixture)
		{
			Fixture = fixture;
		}

		[Fact]
		public void VkRegistry_TypesBaseType_Mapped()
		{
			var subject = Fixture.VkRegistry;

			subject.BaseTypes.Should().HaveCount(4);
		}

		[Theory]
		[InlineData(0, "VkSampleMask", "uint32_t", "\n      typedef uint32_tVkSampleMask;\n    ")]
		[InlineData(1, "VkBool32", "uint32_t", "\n      typedef uint32_tVkBool32;\n    ")]
		[InlineData(2, "VkFlags", "uint32_t", "\n      typedef uint32_tVkFlags;\n    ")]
		[InlineData(3, "VkDeviceSize", "uint64_t", "\n      typedef uint64_tVkDeviceSize;\n    ")]
		public void VkRegistry_TypeBaseTypes_MappedCorrectly(int index, string name, string type, string requires)
		{
			var subject = Fixture.VkRegistry;

			subject.BaseTypes[index].Name.Should().Be(name);
			subject.BaseTypes[index].Type.Should().Be(type);
			subject.BaseTypes[index].Value.Should().Be(requires);
		}

		private SpecFixture Fixture { get; set; }
	}
}
