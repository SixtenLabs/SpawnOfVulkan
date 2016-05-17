using Xunit;
using FluentAssertions;
using NSubstitute;

using AutoMapper;
using System.Linq;
using System.Collections.Generic;
using SixtenLabs.Spawn.CSharp;

namespace SixtenLabs.Spawn.Vulkan.Tests
{
	public class EnumMapperTests
	{
		private XmlFileLoader<registry> FileLoader { get; set; }

		private VulkanSettings Settings { get; } = new VulkanSettings();

		public EnumMapperTests()
		{
			FileLoader = new XmlFileLoader<registry>(Settings, new WebClientFactory());

			var config = new MapperConfiguration(cfg =>
			{
				cfg.AddProfile(new RegistryEnumMapper());
			});

			Mapper.AssertConfigurationIsValid();

			AMapper = config.CreateMapper();
		}

		private registry SubjectUnderTest()
		{
			FileLoader.LoadRegistry();

			return FileLoader.Registry;
		}

		[Fact]
		public void MapAllEnums()
		{
			var vk = SubjectUnderTest();

			var types = vk.enums.Where(x => x.name != "API Constants");

			types.Should().HaveCount(74);

			var maps = new List<EnumDefinition>();

			foreach (var type in types)
			{
				var map = AMapper.Map<EnumDefinition>(type);
				maps.Add(map);
			}

			maps.Should().HaveCount(74);
		}

		[Fact]
		public void MapNonFlagsEnum()
		{
			var vk = SubjectUnderTest();

			var type = vk.enums.Where(x => x.name == "VkImageLayout").FirstOrDefault();

			var map = AMapper.Map<EnumDefinition>(type);

			map.SpecName.Should().Be("VkImageLayout");
			//map.TranslatedName.Should().Be("ImageLayout");
			map.HasFlags.Should().BeFalse();
			map.Members.Should().HaveCount(9);
		}

		[Fact]
		public void MapFlagsEnum()
		{
			var vk = SubjectUnderTest();

			var type = vk.enums.Where(x => x.name == "VkQueueFlagBits").FirstOrDefault();

			var map = AMapper.Map<EnumDefinition>(type);

			map.SpecName.Should().Be("VkQueueFlagBits");
			//map.TranslatedName.Should().Be("QueueFlags");
			map.HasFlags.Should().BeTrue();
			map.Members.Should().HaveCount(4);
		}

		[Fact]
		public void MapAccessFlagsEnum()
		{
			var vk = SubjectUnderTest();

			var type = vk.enums.Where(x => x.name == "VkAccessFlagBits").FirstOrDefault();

			var map = AMapper.Map<EnumDefinition>(type);

			map.SpecName.Should().Be("VkAccessFlagBits");
			//map.TranslatedName.Should().Be("QueueFlags");
			map.HasFlags.Should().BeTrue();
			map.Members.Should().HaveCount(17);

			map.Members[0].Value.Should().Be("0x1");
			map.Members[1].Value.Should().Be("0x2");
		}

		private IMapper AMapper { get; }
	}
}
