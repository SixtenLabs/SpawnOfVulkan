using Xunit;
using FluentAssertions;
using NSubstitute;
using System.Collections.Generic;
using AutoMapper;
using SixtenLabs.Spawn.Vulkan.Spec;

namespace SixtenLabs.Spawn.Vulkan.Tests
{
	public class VulkanGeneratorTests
	{
		public VulkanGeneratorTests()
		{
			CreateMockRegistry();
		}

		private VulkanGenerator SubjectUnderTest()
		{
			var creators = CreateMockCreators();
			MockSpawnService = Substitute.For<ISpawnService>();
			MockSpawnSpec = Substitute.For<ISpawnSpec<VkRegistry>>();
			MockMapper = Substitute.For<IMapper>();
			
			return new VulkanGenerator(creators, MockSpawnService, MockSpawnSpec, MockMapper);
		}

		//[Fact]
		//public void Start_MapTypes_CalledOnceForEachType()
		//{
		//	var subject = SubjectUnderTest();

		//	MockSpawnSpec.SpecTree.Returns(MockRegistry);

		//	subject.Start();

		//	MockMapper.Received(MockRegistry.types.Length).Map<registryType, SpecTypeDefinition>(Arg.Any<registryType>());
		//}

		[Fact]
		public void Start_Initialize_SpawnInitializeCalled()
		{
			var subject = SubjectUnderTest();

			MockSpawnSpec.SpecTree.Returns(MockRegistry);

			subject.Start();

			MockSpawnService.Received(1).Initialize(Arg.Is(@"C:\Users\pglas\Documents\GitHub\SixtenLabs\SpawnOfVulkan\SpawnOfVulkan.sln"));
		}

		[Fact]
		public void Start_Initialize_SpawnSpecProcessRegistryCalled()
		{
			var subject = SubjectUnderTest();

			MockSpawnSpec.SpecTree.Returns(MockRegistry);

			subject.Start();

			MockSpawnSpec.Received(1).ProcessRegistry();
		}

		[Fact]
		public void Start_MapEnums_CalledOnceForEachType()
		{
			var subject = SubjectUnderTest();

			MockSpawnSpec.SpecTree.Returns(MockRegistry);

			subject.Start();

			MockMapper.Received(MockRegistry.Enums.Count).Map<VkEnumValue, SpecTypeDefinition>(Arg.Any<VkEnumValue>());
		}

		[Fact]
		public void Start_MapCommands_CalledOnceForEachType()
		{
			var subject = SubjectUnderTest();

			MockSpawnSpec.SpecTree.Returns(MockRegistry);

			subject.Start();

			MockMapper.Received(MockRegistry.Commands.Count).Map<VkEnumValue, SpecTypeDefinition>(Arg.Any<VkEnumValue>());
		}

		private void CreateMockRegistry()
		{
			MockRegistry = Substitute.For<VkRegistry>();
			//MockRegistry. = new registryType[] { new registryType() { name = "blah" } };
			//MockRegistry.enums = new registryEnums[] { new registryEnums() { name = "blah", @enum = new registryEnumsEnum[] { new registryEnumsEnum() { name = "blah" } }  } };
			//MockRegistry.commands = new registryCommand[] { new registryCommand() { proto = new registryCommandProto() { name = "blah" } } };
		}

		private IEnumerable<ICreator> CreateMockCreators()
		{
			var creators = new List<ICreator>();

			MockCreatorOne = Substitute.For<ICreator>();
			MockCreatorOne.Off.Returns(false);
			MockCreatorOne.GeneratedComments.Returns(new List<string>());

			MockCreatorTwo = Substitute.For<ICreator>();
			MockCreatorTwo.Off.Returns(false);
			MockCreatorTwo.GeneratedComments.Returns(new List<string>());

			creators.Add(MockCreatorOne);
			creators.Add(MockCreatorTwo);

			return creators;
		}

		private VkRegistry MockRegistry { get; set; }
		
		private ICreator MockCreatorOne { get; set; }

		private ICreator MockCreatorTwo { get; set; }

		private ISpawnService MockSpawnService { get; set; }

		private ISpawnSpec<VkRegistry> MockSpawnSpec { get; set; }

		private IMapper MockMapper { get; set; }
	}
}
