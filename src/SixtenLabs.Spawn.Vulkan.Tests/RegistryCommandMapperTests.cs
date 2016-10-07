using Xunit;
using FluentAssertions;
using NSubstitute;

using System.Linq;
using System.Collections.Generic;
using SixtenLabs.Spawn.CSharp;
using SixtenLabs.Spawn.Vulkan.Spec;

namespace SixtenLabs.Spawn.Vulkan.Tests
{
	public class RegistryCommandMapperTests : IClassFixture<SpecFixture>
	{
		public RegistryCommandMapperTests(SpecFixture fixture)
		{
			Fixture = fixture;
		}

		private SpecFixture Fixture { get; set; }

		private VkRegistry SubjectUnderTest()
		{
			return Fixture.VkRegistry;
		}

		[Fact]
		public void MapAllCommands()
		{
			var vk = SubjectUnderTest();

			var commands = vk.Commands;

			commands.Should().HaveCount(178);

			var maps = new List<MethodDefinition>();

			foreach (var type in commands)
			{
				var map = Fixture.SpecMapper.Map<MethodDefinition>(type);
				maps.Add(map);
			}

			maps.Should().HaveCount(178);
		}

		[Fact]
		public void MapVkInstanceHandle()
		{
			var vk = SubjectUnderTest();

			var type = vk.Commands.Where(x => x.Name == "vkCreateInstance").FirstOrDefault();

			var map = Fixture.SpecMapper.Map<MethodDefinition>(type);

			map.Name.Original.Should().Be("vkCreateInstance");
			map.ReturnType.Original.Should().Be("VkResult");
			map.ParameterDefinitions.Should().HaveCount(3);

			map.ParameterDefinitions[0].Name.Original.Should().Be("pCreateInfo");
			map.ParameterDefinitions[0].ParameterType.Original.Should().Be("VkInstanceCreateInfo");
			//map.Parameters[0].ExternSync.Should().BeFalse();
			//map.Parameters[0].IsOptional.Should().BeFalse();
			//map.Parameters[0].IsPointer.Should().BeTrue();

			map.ParameterDefinitions[1].Name.Original.Should().Be("pAllocator");
			map.ParameterDefinitions[1].ParameterType.Original.Should().Be("VkAllocationCallbacks");
			//map.Parameters[1].ExternSync.Should().BeFalse();
			//map.Parameters[1].IsOptional.Should().BeTrue();
			//map.Parameters[1].IsPointer.Should().BeTrue();

			map.ParameterDefinitions[2].Name.Original.Should().Be("pInstance");
			map.ParameterDefinitions[2].ParameterType.Original.Should().Be("VkInstance");
			//map.Parameters[2].ExternSync.Should().BeFalse();
			//map.Parameters[2].IsOptional.Should().BeFalse();
			//map.Parameters[2].IsPointer.Should().BeTrue();
		}
	}
}
