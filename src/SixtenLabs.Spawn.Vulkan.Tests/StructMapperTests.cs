using Xunit;
using FluentAssertions;

using AutoMapper;
using System.Linq;
using System.Collections.Generic;
using SixtenLabs.Spawn.CSharp;

namespace SixtenLabs.Spawn.Vulkan.Tests
{
	public class StructMapperTests
	{
		private XmlFileLoader<registry> FileLoader { get; set; }

		private VulkanSettings Settings { get; } = new VulkanSettings();

		public StructMapperTests()
		{
			FileLoader = new XmlFileLoader<registry>(Settings, new WebClientFactory());

			var config = new MapperConfiguration(cfg =>
			{
				cfg.AddProfile(new RegistryTypeMapper());
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
		public void MapAllStructs()
		{
			var vk = SubjectUnderTest();

			var types = vk.types.Where(x => x.category == "struct");

			types.Should().HaveCount(129);

			var maps = new List<StructDefinition>();

			foreach (var type in types)
			{
				var map = AMapper.Map<StructDefinition>(type);
				maps.Add(map);
			}

			maps.Should().HaveCount(129);
		}

		[Fact]
		public void MapVkOffset2DStruct()
		{
			var vk = SubjectUnderTest();

			var type = vk.types.Where(x => x.category == "struct" && x.name == "VkOffset2D").FirstOrDefault();

			var map = AMapper.Map<StructDefinition>(type);

			map.SpecName.Should().Be("VkOffset2D");
			map.Fields.Should().HaveCount(2);
		}

		[Fact]
		public void MapVkPhysicalDevicePropertiesStruct()
		{
			var vk = SubjectUnderTest();

			var type = vk.types.Where(x => x.category == "struct" && x.name == "VkPhysicalDeviceProperties").FirstOrDefault();

			var map = AMapper.Map<StructDefinition>(type);

			map.SpecName.Should().Be("VkPhysicalDeviceProperties");
			map.Fields.Should().HaveCount(9);
		}

		[Fact]
		public void MapVkViewportStruct()
		{
			var vk = SubjectUnderTest();

			var type = vk.types.Where(x => x.category == "struct" && x.name == "VkViewport").FirstOrDefault();

			var map = AMapper.Map<StructDefinition>(type);

			map.SpecName.Should().Be("VkViewport");
			map.SpecReturnType.Should().BeNull();
			map.Fields.Should().HaveCount(6);

			map.Fields[0].SpecName.Should().Be("x");
			map.Fields[0].SpecReturnType.Should().Be("float");

			// We return the SpecType if we have not created a translated type.
			//map.Fields[0].TranslatedReturnType.Should().Be("float");
		}

		[Fact]
		public void MapVkImageBlit()
		{
			var vk = SubjectUnderTest();

			var type = vk.types.Where(x => x.category == "struct" && x.name == "VkImageBlit").FirstOrDefault();

			var map = AMapper.Map<StructDefinition>(type);

			map.SpecName.Should().Be("VkImageBlit");
			map.SpecReturnType.Should().BeNull();
			map.Fields.Should().HaveCount(4);

			map.Fields[0].SpecName.Should().Be("srcSubresource");
			map.Fields[0].SpecReturnType.Should().Be("VkImageSubresourceLayers");
			map.Fields[0].ReturnTypeIsArray.Should().BeFalse();
			
			// We return the SpecType if we have not created a translated type.
			//map.Fields[0].TranslatedReturnType.Should().BeNull("ImageSubresourceLayers");

			map.Fields[1].SpecName.Should().Be("srcOffsets");
			map.Fields[1].SpecReturnType.Should().Be("VkOffset3D");
			map.Fields[1].ReturnTypeIsArray.Should().BeTrue();

			// We return the SpecType if we have not created a translated type.
			//map.Fields[1].TranslatedReturnType.Should().Be("Offset3D");

			map.Fields[2].SpecName.Should().Be("dstSubresource");
			map.Fields[2].SpecReturnType.Should().Be("VkImageSubresourceLayers");
			map.Fields[2].ReturnTypeIsArray.Should().BeFalse();

			// We return the SpecType if we have not created a translated type.
			//map.Fields[2].TranslatedReturnType.Should().Be("ImageSubresourceLayers");

			map.Fields[3].SpecName.Should().Be("dstOffsets");
			map.Fields[3].SpecReturnType.Should().Be("VkOffset3D");
			map.Fields[3].ReturnTypeIsArray.Should().BeTrue();

			// We return the SpecType if we have not created a translated type.
			//map.Fields[3].TranslatedReturnType.Should().Be("Offset3D");
		}

		private IMapper AMapper { get; }
	}
}
