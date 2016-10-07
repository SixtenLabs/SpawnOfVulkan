using Xunit;
using FluentAssertions;
using NSubstitute;

using System.Linq;
using System.Collections.Generic;
using SixtenLabs.Spawn.CSharp;
using SixtenLabs.Spawn.Vulkan.Spec;

namespace SixtenLabs.Spawn.Vulkan.Tests
{
	public class HandleMapperTests : IClassFixture<SpecFixture>
	{
		public HandleMapperTests(SpecFixture fixture)
		{
			Fixture = fixture;
		}

		private SpecFixture Fixture { get; set; }

		private VkRegistry SubjectUnderTest()
		{
			return Fixture.VkRegistry;
		}

		[Fact]
		public void MapAllHandles()
		{
			var vk = SubjectUnderTest();

			var types = vk.Handles;

			types.Should().HaveCount(30);

			var maps = new List<StructDefinition>();

			foreach (var type in types)
			{
				var map = Fixture.SpecMapper.Map<StructDefinition>(type);
				maps.Add(map);
			}

			maps.Should().HaveCount(30);
		}

		[Fact]
		public void MapVkInstanceHandle()
		{
			var vk = SubjectUnderTest();

			var type = vk.Handles.Where(x => x.Name == "VkInstance").FirstOrDefault();

			var map = Fixture.SpecMapper.Map<StructDefinition>(type);

			map.Name.Original.Should().Be("VkInstance");
			map.SpecDerivedType.Should().BeNull();
		}

		//[Fact]
		//public void MapVkInstanceHandle()
		//{
		//	var vk = SubjectUnderTest();

		//	var type = vk.types.Where(x => x.category == "handle" && (string)x.Items[1] == "VkInstance").FirstOrDefault();

		//	var map = AMapper.Map<StructDefinition>(type);

		//	map.Name.Original.Should().Be("VkInstance");
		//	map.SpecDerivedType.Should().BeNull();
		//}

		[Fact]
		public void MapVkCommandBufferHandle()
		{
			var vk = SubjectUnderTest();

			var type = vk.Handles.Where(x => x.Name == "VkCommandBuffer").FirstOrDefault();

			var map = Fixture.SpecMapper.Map<StructDefinition>(type);

			map.Name.Original.Should().Be("VkCommandBuffer");
			map.SpecDerivedType.Should().Be("VkCommandPool");
		}
	}
}
