using Xunit;
using FluentAssertions;

using System.Linq;

namespace SixtenLabs.Spawn.Vulkan.Tests.Spec
{
	public class VkCommandMapTests : IClassFixture<SpecFixture>
	{
		public VkCommandMapTests(SpecFixture fixture)
		{
			Fixture = fixture;
		}

		[Fact]
		public void VkRegistry_VkCommands_Mapped()
		{
			var subject = Fixture.VkRegistry;

			subject.Commands.Should().HaveCount(174);
		}

		[Theory]
		[InlineData("vkCreateInstance", "VkResult", "VK_SUCCESS", "VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY,VK_ERROR_INITIALIZATION_FAILED,VK_ERROR_LAYER_NOT_PRESENT,VK_ERROR_EXTENSION_NOT_PRESENT,VK_ERROR_INCOMPATIBLE_DRIVER", 3, 0)]
		[InlineData("vkDestroyInstance", "void", null, null, 2, 3)]
		public void VkRegistry_VkCommands_MappedCorrectly(string name, string type, string successCodes, string errorCodes, int parametersCount, int validityCount)
		{
			var subject = Fixture.VkRegistry.Commands.Where(x => x.Name == name).FirstOrDefault();

			subject.Type.Should().Be(type);
			subject.SuccessCodes.Should().Be(successCodes);
			subject.ErrorCodes.Should().Be(errorCodes);
			subject.Parameters.Count.Should().Be(parametersCount);
			subject.Validity.Count.Should().Be(validityCount);
		}

		[Theory]
		[InlineData("vkCreateInstance", 0, "pCreateInfo", "VkInstanceCreateInfo", true, 1, null, null, null)]
		[InlineData("vkEnumerateInstanceLayerProperties", 0, "pPropertyCount", "uint32_t", false, 1, null, "false,true", null)]
		[InlineData("vkEnumerateInstanceLayerProperties", 1, "pProperties", "VkLayerProperties", false, 1, "pPropertyCount", "true", null)]
		[InlineData("vkQueueSubmit", 0, "queue", "VkQueue", false, 0, null, null, "true")]
		public void VkRegistry_VkCommandParameters_MappedCorrectly(string name, int valueIndex, string parameterName, string returnType, bool isConst, int pointerRank, string len, string isOptional, string externalSync)
		{
			var subject = Fixture.VkRegistry.Commands.Where(x => x.Name == name).FirstOrDefault();

			subject.Parameters[valueIndex].Name.Should().Be(parameterName);
			subject.Parameters[valueIndex].ReturnType.Should().Be(returnType);
			subject.Parameters[valueIndex].IsConst.Should().Be(isConst);
			subject.Parameters[valueIndex].PointerRank.Should().Be(pointerRank);
			subject.Parameters[valueIndex].Len.Should().Be(len);
			subject.Parameters[valueIndex].IsOptional.Should().Be(isOptional);
			subject.Parameters[valueIndex].ExternSync.Should().Be(externalSync);
		}

		private SpecFixture Fixture { get; set; }
	}
}
