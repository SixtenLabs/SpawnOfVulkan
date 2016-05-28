using Xunit;
using FluentAssertions;

using System.Linq;

namespace SixtenLabs.Spawn.Vulkan.Tests.Spec
{
	public class VkTypeFuncPointerMapTests : IClassFixture<SpecFixture>
	{
		public VkTypeFuncPointerMapTests(SpecFixture fixture)
		{
			Fixture = fixture;
		}

		[Fact]
		public void VkRegistry_TypesFuncPointers_Mapped()
		{
			var subject = Fixture.VkRegistry;

			subject.TypeFuncPointers.Should().HaveCount(7);
		}

		[Theory]
		[InlineData("PFN_vkInternalAllocationNotification", "void", 4)]
		[InlineData("PFN_vkInternalFreeNotification", "void", 4)]
		[InlineData("PFN_vkReallocationFunction", "void", 5)]
		[InlineData("PFN_vkAllocationFunction", "void", 4)]
		[InlineData("PFN_vkFreeFunction", "void", 2)]
		[InlineData("PFN_vkVoidFunction", "void", 0)]
		[InlineData("PFN_vkDebugReportCallbackEXT", "VkBool32", 8)]
		public void VkRegistry_TypesFuncPointers_MappedCorrectly(string name, string returnType, int parameterCount)
		{
			var subject = Fixture.VkRegistry.TypeFuncPointers.Where(x => x.Name == name).FirstOrDefault();

			subject.ReturnType.Should().Be(returnType);
			subject.Parameters.Count.Should().Be(parameterCount);
		}

		[Theory]
		[InlineData("PFN_vkInternalAllocationNotification", 0, "pUserData", "void", true, false)]
		[InlineData("PFN_vkInternalAllocationNotification", 1, "size", "size_t", false, false)]
		[InlineData("PFN_vkInternalAllocationNotification", 2, "allocationType", "VkInternalAllocationType", false, false)]
		[InlineData("PFN_vkInternalAllocationNotification", 3, "allocationScope", "VkSystemAllocationScope", false, false)]

		[InlineData("PFN_vkInternalFreeNotification", 0, "pUserData", "void", true, false)]
		[InlineData("PFN_vkInternalFreeNotification", 1, "size", "size_t", false, false)]
		[InlineData("PFN_vkInternalFreeNotification", 2, "allocationType", "VkInternalAllocationType", false, false)]
		[InlineData("PFN_vkInternalFreeNotification", 3, "allocationScope", "VkSystemAllocationScope", false, false)]

		[InlineData("PFN_vkReallocationFunction", 0, "pUserData", "void", true, false)]
		[InlineData("PFN_vkReallocationFunction", 1, "pOriginal", "void", true, false)]
		[InlineData("PFN_vkReallocationFunction", 2, "size", "size_t", false, false)]
		[InlineData("PFN_vkReallocationFunction", 3, "alignment", "size_t", false, false)]
		[InlineData("PFN_vkReallocationFunction", 4, "allocationScope", "VkSystemAllocationScope", false, false)]

		[InlineData("PFN_vkAllocationFunction", 0, "pUserData", "void", true, false)]
		[InlineData("PFN_vkAllocationFunction", 1, "size", "size_t", false, false)]
		[InlineData("PFN_vkAllocationFunction", 2, "alignment", "size_t", false, false)]
		[InlineData("PFN_vkAllocationFunction", 3, "allocationScope", "VkSystemAllocationScope", false, false)]

		[InlineData("PFN_vkFreeFunction", 0, "pUserData", "void", true, false)]
		[InlineData("PFN_vkFreeFunction", 1, "pMemory", "void", true, false)]

		[InlineData("PFN_vkDebugReportCallbackEXT", 0, "flags", "VkDebugReportFlagsEXT", false, false)]
		[InlineData("PFN_vkDebugReportCallbackEXT", 1, "objectType", "VkDebugReportObjectTypeEXT", false, false)]
		[InlineData("PFN_vkDebugReportCallbackEXT", 2, "object", "uint64_t", false, false)]
		[InlineData("PFN_vkDebugReportCallbackEXT", 3, "location", "size_t", false, false)]
		[InlineData("PFN_vkDebugReportCallbackEXT", 4, "messageCode", "int32_t", false, false)]
		[InlineData("PFN_vkDebugReportCallbackEXT", 5, "pLayerPrefix", "char", true, true)]
		[InlineData("PFN_vkDebugReportCallbackEXT", 6, "pMessage", "char", true, true)]
		[InlineData("PFN_vkDebugReportCallbackEXT", 7, "pUserData", "void", true, false)]
		public void VkRegistry_TypesFuncPointersParameters_MappedCorrectly(string funcPointerName, int parameterIndex, string name, string returnType, bool isPointer, bool isConst)
		{
			var subject = Fixture.VkRegistry.TypeFuncPointers.Where(x => x.Name == funcPointerName).FirstOrDefault();

			subject.Parameters[parameterIndex].Name.Should().Be(name);
			subject.Parameters[parameterIndex].ReturnType.Should().Be(returnType);
			subject.Parameters[parameterIndex].IsPointer.Should().Be(isPointer);
			subject.Parameters[parameterIndex].IsConst.Should().Be(isConst);
		}

		private SpecFixture Fixture { get; set; }
	}
}
