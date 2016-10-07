using Xunit;
using FluentAssertions;
using NSubstitute;

using AutoMapper;
using System.Xml.Linq;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using SixtenLabs.Spawn.Vulkan.Spec;

namespace SixtenLabs.Spawn.Vulkan.Tests
{
	public class SpecTypeMapperTests : IClassFixture<SpecFixture>
	{
		public SpecTypeMapperTests(SpecFixture fixture)
		{
			Fixture = fixture;
		}

		private SpecFixture Fixture { get; set; }

		private VkRegistry SubjectUnderTest()
		{
			return Fixture.VkRegistry;
		}

		//[Fact]
		//public void all_Types_Process()
		//{
		//	var vk = SubjectUnderTest();

		//	var types = vk.types;

		//	types.Should().HaveCount(377);

		//	var maps = GetMapsFromTypes(types);

		//	maps.Should().HaveCount(377);
		//	var nullTranslatedNameMaps = maps.Where(x => x.Translated == null);
		//	nullTranslatedNameMaps.Count(x => x.Translated == null).Should().Be(0);

		//	var nullSpecNameMaps = maps.Where(x => x.SpecName == null);
		//	nullSpecNameMaps.Count(x => x.SpecName == null).Should().Be(0);
		//}

		//[Fact]
		//public void vkPlatform_Types_Process()
		//{
		//	var vk = SubjectUnderTest();

		//	var types = vk.Requires;

		//	types.Should().HaveCount(8);

		//	var maps = GetMapsFromTypes(types);

		//	maps.Should().HaveCount(8);
		//}

		//[Fact]
		//public void requiresNotEnums_Types_Process()
		//{
		//	var vk = SubjectUnderTest();

		//	var types = vk.types.Where(x => !string.IsNullOrEmpty(x.requires) && !x.requires.Contains("Bits"));

		//	types.Should().HaveCount(21);

		//	var maps = GetMapsFromTypes(types);

		//	maps.Should().HaveCount(21);
		//}

		[Fact]
		public void basetype_Types_Process()
		{
			var vk = SubjectUnderTest();

			var types = vk.BaseTypes;

			types.Should().HaveCount(4);

			var maps = GetMapsFromTypes(types);

			maps.Should().HaveCount(4);
		}

		[Fact]
		public void bitmask_Types_Process()
		{
			var vk = SubjectUnderTest();

			var types = vk.Bitmasks;

			types.Should().HaveCount(73);

			var maps = GetMapsFromTypes(types);

			maps.Should().HaveCount(73);
		}

		[Fact]
		public void handle_Types_Process()
		{
			var vk = SubjectUnderTest();

			var types = vk.Handles;

			types.Should().HaveCount(30);

			var maps = GetMapsFromTypes(types);

			maps.Should().HaveCount(30);
		}

		[Fact]
		public void enum_Types_Process()
		{
			var vk = SubjectUnderTest();

			var types = vk.TypeEnums;

			types.Should().HaveCount(98);

			var maps = GetMapsFromTypes(types);

			maps.Should().HaveCount(98);
		}

		[Fact]
		public void funcpointer_Types_Process()
		{
			var vk = SubjectUnderTest();

			var types = vk.TypeFuncPointers;

			types.Should().HaveCount(7);

			var maps = GetMapsFromTypes(types);

			maps.Should().HaveCount(7);
		}

		[Fact]
		public void struct_Types_Process()
		{
			var vk = SubjectUnderTest();

			var types = vk.TypeStructs;

			types.Should().HaveCount(139);

			var maps = GetMapsFromTypes(types);

			maps.Should().HaveCount(139);
		}

		//[Fact]
		//public void structx_Types_Process()
		//{
		//	var vk = SubjectUnderTest();

		//	var types = vk.TypeStructs;

		//	var maps = GetMapsFromTypes(types);

		//	var typeDef = maps.Where(x => x.SpecName == "VkDebugMarkerObjectNameInfoEXT").FirstOrDefault();

		//	typeDef.SpecName.Should().Be("VkDebugMarkerObjectNameInfoEXT");
		//	typeDef.Translated.Should().Be("DebugMarkerObjectNameInfoExt");
		//	typeDef.Children.Should().HaveCount(5);

		//	maps.Should().HaveCount(129);
		//}

		[Fact]
		public void union_Types_Process()
		{
			var vk = SubjectUnderTest();

			var types = vk.TypeUnions;

			types.Should().HaveCount(2);

			var maps = GetMapsFromTypes(types);

			maps.Should().HaveCount(2);
		}

		[Fact]
		public void include_Types_Process()
		{
			var vk = SubjectUnderTest();

			var types = vk.Includes;

			types.Should().HaveCount(8);

			var maps = GetMapsFromTypes(types);

			maps.Should().HaveCount(8);
		}

		[Fact]
		public void define_Types_Process()
		{
			var vk = SubjectUnderTest();

			var types = vk.Defines;

			types.Should().HaveCount(10);

			var maps = GetMapsFromTypes(types);

			maps.Should().HaveCount(10);
		}

		[Fact]
		public void enumValues_Types_Process()
		{
			var vk = SubjectUnderTest();

			var types = vk.Enums.SelectMany(x => x.Values);
			types.Should().HaveCount(632);

			var maps = GetMapsFromTypes(types);

			maps.Should().HaveCount(632);
		}

		[Fact]
		public void Command_Types_Process()
		{
			var vk = SubjectUnderTest();

			var types = vk.Commands;

			types.Should().HaveCount(178);

			var maps = GetMapsFromTypes(types);

			maps.Should().HaveCount(178);
		}

		private IList<SpecTypeDefinition> GetMapsFromTypes<T>(IEnumerable<T> types) where T : class
		{
			var maps = new List<SpecTypeDefinition>();

			foreach (var type in types)
			{
				var map = Fixture.SpecMapper.Map<SpecTypeDefinition>(type);
				maps.Add(map);
			}

			return maps;
		}
	}
}
