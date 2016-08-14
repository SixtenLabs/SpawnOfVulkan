using Xunit;
using FluentAssertions;

using System.Linq;

namespace SixtenLabs.Spawn.Vulkan.Tests.Spec
{
	public class VkTypeStructMapTests : IClassFixture<SpecFixture>
	{
		public VkTypeStructMapTests(SpecFixture fixture)
		{
			Fixture = fixture;
		}

		[Fact]
		public void VkRegistry_TypesStructs_Mapped()
		{
			var subject = Fixture.VkRegistry;

			subject.TypeStructs.Should().HaveCount(132);
		}

		[Theory]
		[InlineData("VkOffset2D", false, 2, 0)]
		[InlineData("VkViewport", false, 6, 7)]
		[InlineData("VkPhysicalDeviceProperties", true, 9, 0)]
		public void VkRegistry_TypesStructs_MappedCorrectly(string structName, bool isReturnedOnly, int memberCount, int validityCount)
		{
			var subject = Fixture.VkRegistry.TypeStructs.Where(x => x.Name == structName).FirstOrDefault();

			subject.IsReturnedOnly.Should().Be(isReturnedOnly);
			subject.Members.Count.Should().Be(memberCount);
			subject.Validity.Count.Should().Be(validityCount);
		}

		[Theory]
		[InlineData("VkOffset2D", 0, "x", "int32_t", false, false, null, null, null, false, null, null)]
		[InlineData("VkOffset2D", 1, "y", "int32_t", false, false, null, null, null, false, null, null)]
		[InlineData("VkViewport", 0, "x", "float", false, false, null, null, null, false, null, null)]
		[InlineData("VkViewport", 1, "y", "float", false, false, null, null, null, false, null, null)]
		[InlineData("VkViewport", 2, "width", "float", false, false, null, null, null, false, null, null)]
		[InlineData("VkViewport", 3, "height", "float", false, false, null, null, null, false, null, null)]
		[InlineData("VkViewport", 4, "minDepth", "float", false, false, null, null, null, false, null, null)]
		[InlineData("VkViewport", 5, "maxDepth", "float", false, false, null, null, null, false, null, null)]
		[InlineData("VkPhysicalDeviceProperties", 5, "deviceName", "char", false, false, null, null, null, true, "VK_MAX_PHYSICAL_DEVICE_NAME_SIZE", null)]
		[InlineData("VkApplicationInfo", 2, "pApplicationName", "char", true, true, "true", null, "null-terminated", false, null, null)]
		[InlineData("VkDeviceCreateInfo", 0, "sType", "VkStructureType", false, false, null, null, null, false, null, null)]
		[InlineData("VkDescriptorImageInfo", 0, "sampler", "VkSampler", false, false, null, "true", null, false, null, "Sampler to write to the descriptor in case it is a SAMPLER or COMBINED_IMAGE_SAMPLER descriptor. Ignored otherwise.")]
		[InlineData("VkImageBlit", 1, "srcOffsets", "VkOffset3D", false, false, null, null, null, true, "2", "Specified in pixels for both compressed and uncompressed images")]
		public void VkRegistry_TypesStructMembers_MappedCorrectly(string structName, int memberIndex, string name, string returnType, bool isPointer, bool isConst,
			string optional, string noAutoValidity, string len, bool isArray, string arrayCount, string comment)
		{
			var subject = Fixture.VkRegistry.TypeStructs.Where(x => x.Name == structName).FirstOrDefault();

			subject.Members[memberIndex].Name.Should().Be(name);
			subject.Members[memberIndex].ReturnType.Should().Be(returnType);
			subject.Members[memberIndex].IsPointer.Should().Be(isPointer);
			subject.Members[memberIndex].IsConst.Should().Be(isConst);
			subject.Members[memberIndex].Optional.Should().Be(optional);
			subject.Members[memberIndex].NoAutoValidity.Should().Be(noAutoValidity);
			subject.Members[memberIndex].Len.Should().Be(len);
			subject.Members[memberIndex].IsArray.Should().Be(isArray);
			subject.Members[memberIndex].ArrayCount.Should().Be(arrayCount);
			subject.Members[memberIndex].Comment.Should().Be(comment);
		}

		private SpecFixture Fixture { get; set; }
	}
}
