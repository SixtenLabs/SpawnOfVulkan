using Xunit;
using FluentAssertions;

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
		[InlineData(0, "PFN_vkInternalAllocationNotification", "void", 4)]
		[InlineData(1, "PFN_vkInternalFreeNotification", "void", 4)]
		[InlineData(2, "PFN_vkReallocationFunction", "void", 5)]
		[InlineData(3, "PFN_vkAllocationFunction", "void", 4)]
		[InlineData(4, "PFN_vkFreeFunction", "void", 2)]
		[InlineData(5, "PFN_vkVoidFunction", "void", 0)]
		[InlineData(6, "PFN_vkDebugReportCallbackEXT", "VkBool32", 8)]
		public void VkRegistry_TypesFuncPointers_MappedCorrectly(int index, string name, string returnType, int parameterCount)
		{
			var subject = Fixture.VkRegistry;

			subject.TypeFuncPointers[index].Name.Should().Be(name);
			subject.TypeFuncPointers[index].ReturnType.Should().Be(returnType);
			subject.TypeFuncPointers[index].Parameters.Count.Should().Be(parameterCount);
		}

		[Theory]
		[InlineData(0, 0, "pUserData", "void", true, false)]
		[InlineData(0, 1, "size", "size_t", false, false)]
		[InlineData(0, 2, "allocationType", "VkInternalAllocationType", false, false)]
		[InlineData(0, 3, "allocationScope", "VkSystemAllocationScope", false, false)]

		[InlineData(1, 0, "pUserData", "void", true, false)]
		[InlineData(1, 1, "size", "size_t", false, false)]
		[InlineData(1, 2, "allocationType", "VkInternalAllocationType", false, false)]
		[InlineData(1, 3, "allocationScope", "VkSystemAllocationScope", false, false)]

		[InlineData(2, 0, "pUserData", "void", true, false)]
		[InlineData(2, 1, "pOriginal", "void", true, false)]
		[InlineData(2, 2, "size", "size_t", false, false)]
		[InlineData(2, 3, "alignment", "size_t", false, false)]
		[InlineData(2, 4, "allocationScope", "VkSystemAllocationScope", false, false)]

		[InlineData(3, 0, "pUserData", "void", true, false)]
		[InlineData(3, 1, "size", "size_t", false, false)]
		[InlineData(3, 2, "alignment", "size_t", false, false)]
		[InlineData(3, 3, "allocationScope", "VkSystemAllocationScope", false, false)]

		[InlineData(4, 0, "pUserData", "void", true, false)]
		[InlineData(4, 1, "pMemory", "void", true, false)]

		[InlineData(6, 0, "flags", "VkDebugReportFlagsEXT", false, false)]
		[InlineData(6, 1, "objectType", "VkDebugReportObjectTypeEXT", false, false)]
		[InlineData(6, 2, "object", "uint64_t", false, false)]
		[InlineData(6, 3, "location", "size_t", false, false)]
		[InlineData(6, 4, "messageCode", "int32_t", false, false)]
		[InlineData(6, 5, "pLayerPrefix", "char", true, true)]
		[InlineData(6, 6, "pMessage", "char", true, true)]
		[InlineData(6, 7, "pUserData", "void", true, false)]
		public void VkRegistry_TypesFuncPointersParameters_MappedCorrectly(int funcPointerIndex, int parameterIndex, string name, string returnType, bool isPointer, bool isConst)
		{
			var subject = Fixture.VkRegistry;

			subject.TypeFuncPointers[funcPointerIndex].Parameters[parameterIndex].Name.Should().Be(name);
			subject.TypeFuncPointers[funcPointerIndex].Parameters[parameterIndex].ReturnType.Should().Be(returnType);
			subject.TypeFuncPointers[funcPointerIndex].Parameters[parameterIndex].IsPointer.Should().Be(isPointer);
			subject.TypeFuncPointers[funcPointerIndex].Parameters[parameterIndex].IsConst.Should().Be(isConst);
		}

		private SpecFixture Fixture { get; set; }
	}
}
