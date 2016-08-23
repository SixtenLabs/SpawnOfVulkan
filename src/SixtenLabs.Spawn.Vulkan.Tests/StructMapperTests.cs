using Xunit;
using FluentAssertions;

using AutoMapper;
using System.Linq;
using System.Collections.Generic;
using SixtenLabs.Spawn.CSharp;
using SixtenLabs.Spawn.Vulkan.Spec;

namespace SixtenLabs.Spawn.Vulkan.Tests
{
	public class StructMapperTests : IClassFixture<SpecFixture>
	{
		public StructMapperTests(SpecFixture fixture)
		{
			Fixture = fixture;
		}

		private SpecFixture Fixture { get; set; }

		private VkRegistry SubjectUnderTest()
		{
			return Fixture.VkRegistry;
		}

		[Fact]
		public void MapAllStructs()
		{
			var vk = SubjectUnderTest();

			var types = vk.TypeStructs;

			types.Should().HaveCount(132);

			var maps = new List<StructDefinition>();

			foreach (var type in types)
			{
				var map = Fixture.SpecMapper.Map<StructDefinition>(type);
				maps.Add(map);
			}

			maps.Should().HaveCount(132);
		}

		[Fact]
		public void MapVkOffset2DStruct()
		{
			var vk = SubjectUnderTest();

			var type = vk.TypeStructs.Where(x => x.Name == "VkOffset2D").FirstOrDefault();

			var map = Fixture.SpecMapper.Map<StructDefinition>(type);

			map.Name.OriginalName.Should().Be("VkOffset2D");
			map.FieldDefinitions.Should().HaveCount(2);
		}

		[Fact]
		public void MapVkPhysicalDevicePropertiesStruct()
		{
			var vk = SubjectUnderTest();

			var type = vk.TypeStructs.Where(x => x.Name == "VkPhysicalDeviceProperties").FirstOrDefault();

			var map = Fixture.SpecMapper.Map<StructDefinition>(type);

			map.Name.OriginalName.Should().Be("VkPhysicalDeviceProperties");
			map.FieldDefinitions.Should().HaveCount(9);
		}

		[Fact]
		public void MapVkViewportStruct()
		{
			var vk = SubjectUnderTest();

			var type = vk.TypeStructs.Where(x => x.Name == "VkViewport").FirstOrDefault();

			var map = Fixture.SpecMapper.Map<StructDefinition>(type);

			map.Name.OriginalName.Should().Be("VkViewport");
			map.FieldDefinitions.Should().HaveCount(6);

			map.FieldDefinitions[0].Name.OriginalName.Should().Be("x");
			map.FieldDefinitions[0].ReturnType.OriginalName.Should().Be("float");

			// We return the SpecType if we have not created a translated type.
			//map.Fields[0].TranslatedReturnType.Should().Be("float");
		}

		[Fact]
		public void MapVkImageBlit()
		{
			var vk = SubjectUnderTest();

			var type = vk.TypeStructs.Where(x => x.Name == "VkImageBlit").FirstOrDefault();

			var map = Fixture.SpecMapper.Map<StructDefinition>(type);

			map.Name.OriginalName.Should().Be("VkImageBlit");
			map.FieldDefinitions.Should().HaveCount(4);

			map.FieldDefinitions[0].Name.OriginalName.Should().Be("srcSubresource");
			map.FieldDefinitions[0].ReturnType.OriginalName.Should().Be("VkImageSubresourceLayers");
			map.FieldDefinitions[0].ReturnTypeIsArray.Should().BeFalse();

			// We return the SpecType if we have not created a translated type.
			//map.Fields[0].TranslatedReturnType.Should().BeNull("ImageSubresourceLayers");

			map.FieldDefinitions[1].Name.OriginalName.Should().Be("srcOffsets");
			map.FieldDefinitions[1].ReturnType.OriginalName.Should().Be("VkOffset3D");
			map.FieldDefinitions[1].ReturnTypeIsArray.Should().BeTrue();

			// We return the SpecType if we have not created a translated type.
			//map.Fields[1].TranslatedReturnType.Should().Be("Offset3D");

			map.FieldDefinitions[2].Name.OriginalName.Should().Be("dstSubresource");
			map.FieldDefinitions[2].ReturnType.OriginalName.Should().Be("VkImageSubresourceLayers");
			map.FieldDefinitions[2].ReturnTypeIsArray.Should().BeFalse();

			// We return the SpecType if we have not created a translated type.
			//map.Fields[2].TranslatedReturnType.Should().Be("ImageSubresourceLayers");

			map.FieldDefinitions[3].Name.OriginalName.Should().Be("dstOffsets");
			map.FieldDefinitions[3].ReturnType.OriginalName.Should().Be("VkOffset3D");
			map.FieldDefinitions[3].ReturnTypeIsArray.Should().BeTrue();

			// We return the SpecType if we have not created a translated type.
			//map.Fields[3].TranslatedReturnType.Should().Be("Offset3D");
		}

		[Fact]
		public void MapVkDebugMarkerObjectNameInfoEXT()
		{
			var vk = SubjectUnderTest();

			var type = vk.TypeStructs.Where(x => x.Name == "VkDebugMarkerObjectNameInfoEXT").FirstOrDefault();

			var map = Fixture.SpecMapper.Map<StructDefinition>(type);

			map.Name.OriginalName.Should().Be("VkDebugMarkerObjectNameInfoEXT");
			map.FieldDefinitions.Should().HaveCount(5);

			map.FieldDefinitions[0].Name.OriginalName.Should().Be("sType");
			map.FieldDefinitions[0].ReturnType.OriginalName.Should().Be("VkStructureType");

			map.FieldDefinitions[1].Name.OriginalName.Should().Be("pNext");
			map.FieldDefinitions[1].ReturnType.OriginalName.Should().Be("void");

			map.FieldDefinitions[2].Name.OriginalName.Should().Be("objectType");
			map.FieldDefinitions[2].ReturnType.OriginalName.Should().Be("VkDebugReportObjectTypeEXT");

			map.FieldDefinitions[3].Name.OriginalName.Should().Be("object");
			map.FieldDefinitions[3].ReturnType.OriginalName.Should().Be("uint64_t");

			map.FieldDefinitions[4].Name.OriginalName.Should().Be("pObjectName");
			map.FieldDefinitions[4].ReturnType.OriginalName.Should().Be("char");
		}
	}
}
