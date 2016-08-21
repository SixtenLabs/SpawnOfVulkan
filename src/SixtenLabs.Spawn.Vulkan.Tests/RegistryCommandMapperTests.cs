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

			commands.Should().HaveCount(174);

			var maps = new List<MethodDefinition>();

			foreach (var type in commands)
			{
				var map = Fixture.SpecMapper.Map<MethodDefinition>(type);
				maps.Add(map);
			}

			maps.Should().HaveCount(174);
		}

		[Fact]
		public void MapVkInstanceHandle()
		{
			var vk = SubjectUnderTest();

			var type = vk.Commands.Where(x => x.Name == "vkCreateInstance").FirstOrDefault();

			var map = Fixture.SpecMapper.Map<MethodDefinition>(type);

			map.Name.OriginalName.Should().Be("vkCreateInstance");
			map.ReturnType.OriginalName.Should().Be("VkResult");
			map.Parameters.Should().HaveCount(3);

			map.Parameters[0].Name.OriginalName.Should().Be("pCreateInfo");
			map.Parameters[0].ParameterType.OriginalName.Should().Be("VkInstanceCreateInfo");
			//map.Parameters[0].ExternSync.Should().BeFalse();
			//map.Parameters[0].IsOptional.Should().BeFalse();
			//map.Parameters[0].IsPointer.Should().BeTrue();

			map.Parameters[1].Name.OriginalName.Should().Be("pAllocator");
			map.Parameters[1].ParameterType.OriginalName.Should().Be("VkAllocationCallbacks");
			//map.Parameters[1].ExternSync.Should().BeFalse();
			//map.Parameters[1].IsOptional.Should().BeTrue();
			//map.Parameters[1].IsPointer.Should().BeTrue();

			map.Parameters[2].Name.OriginalName.Should().Be("pInstance");
			map.Parameters[2].ParameterType.OriginalName.Should().Be("VkInstance");
			//map.Parameters[2].ExternSync.Should().BeFalse();
			//map.Parameters[2].IsOptional.Should().BeFalse();
			//map.Parameters[2].IsPointer.Should().BeTrue();
		}
	}
}
