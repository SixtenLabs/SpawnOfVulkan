using Xunit;
using FluentAssertions;
using NSubstitute;

using System.Linq;
using System.Collections.Generic;
using SixtenLabs.Spawn.CSharp;
using SixtenLabs.Spawn.Vulkan.Spec;

namespace SixtenLabs.Spawn.Vulkan.Tests
{
	public class EnumMapperTests : IClassFixture<SpecFixture>
	{
		public EnumMapperTests(SpecFixture fixture)
		{
			Fixture = fixture;
		}

		private SpecFixture Fixture { get; set; }

		private VkRegistry SubjectUnderTest()
		{
			return Fixture.VkRegistry;
		}

		[Fact]
		public void MapAllEnums()
		{
			var vk = SubjectUnderTest();

			var types = vk.Enums;

			types.Should().HaveCount(74);

			var maps = new List<EnumDefinition>();

			foreach (var type in types)
			{
				var map = Fixture.SpecMapper.Map<EnumDefinition>(type);
				maps.Add(map);
			}

			maps.Should().HaveCount(74);
		}

		[Fact]
		public void MapNonFlagsEnum()
		{
			var vk = SubjectUnderTest();

			var type = vk.Enums.Where(x => x.Name == "VkImageLayout").FirstOrDefault();

			var map = Fixture.SpecMapper.Map<EnumDefinition>(type);

			map.SpecName.Should().Be("VkImageLayout");
			//map.TranslatedName.Should().Be("ImageLayout");
			map.HasFlags.Should().BeFalse();
			map.Members.Should().HaveCount(9);
		}

		[Fact]
		public void MapFlagsEnum()
		{
			var vk = SubjectUnderTest();

			var type = vk.Enums.Where(x => x.Name == "VkQueueFlagBits").FirstOrDefault();

			var map = Fixture.SpecMapper.Map<EnumDefinition>(type);

			map.SpecName.Should().Be("VkQueueFlagBits");
			//map.TranslatedName.Should().Be("QueueFlags");
			map.HasFlags.Should().BeTrue();
			map.Members.Should().HaveCount(4);
		}

		[Fact]
		public void MapAccessFlagsEnum()
		{
			var vk = SubjectUnderTest();

			var type = vk.Enums.Where(x => x.Name == "VkAccessFlagBits").FirstOrDefault();

			var map = Fixture.SpecMapper.Map<EnumDefinition>(type);

			map.SpecName.Should().Be("VkAccessFlagBits");
			//map.TranslatedName.Should().Be("QueueFlags");
			map.HasFlags.Should().BeTrue();
			map.Members.Should().HaveCount(17);

			map.Members[0].Value.Should().Be("0x1");
			map.Members[1].Value.Should().Be("0x2");
		}
	}
}
