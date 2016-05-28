using Xunit;
using FluentAssertions;

namespace SixtenLabs.Spawn.Vulkan.Tests.Spec
{
	public class VkTagMapTests : IClassFixture<SpecFixture>
	{
		public VkTagMapTests(SpecFixture fixture)
		{
			Fixture = fixture;
		}

		[Fact]
		public void VkRegistry_VkTags_Mapped()
		{
			var subject = Fixture.VkRegistry.Tags;

			subject.Should().HaveCount(20);
		}

		[Theory]
		[InlineData(0, "IMG", "Imagination Technologies", "Michael Worcester @michaelworcester")]
		[InlineData(1, "AMD", "Advanced Micro Devices, Inc.", "Daniel Rakos @aqnuep")]
		[InlineData(2, "ARM", "ARM Limited", "Jan-Harald Fredriksen @janharald")]
		[InlineData(3, "FSL", "Freescale Semiconductor, Inc.", "Norbert Nopper @FslNopper")]
		[InlineData(4, "BRCM", "Broadcom Corporation", "Graeme Leese @gnl21")]
		[InlineData(5, "NXP", "NXP Semiconductors N.V.", "Norbert Nopper @FslNopper")]
		[InlineData(6, "NV", "NVIDIA Corporation", "Daniel Koch @dgkoch")]
		[InlineData(7, "NVX", "NVIDIA Corporation", "Daniel Koch @dgkoch")]
		[InlineData(8, "VIV", "Vivante Corporation", "Yanjun Zhang @yanjunzhang")]
		[InlineData(9, "VSI", "VeriSilicon Holdings Co., Ltd.", "Yanjun Zhang @yanjunzhang")]
		[InlineData(10, "KDAB", "KDAB", "Sean Harmer @seanharmer")]
		[InlineData(11, "ANDROID", "Google, Inc.", "Jesse Hall @jessehall")]
		[InlineData(12, "CHROMIUM", "Google, Inc.", "Jesse Hall @jessehall")]
		[InlineData(13, "GOOGLE", "Google, Inc.", "Jesse Hall @jessehall")]
		[InlineData(14, "QCOM", "Qualcomm Technologies, Inc.", "Maurice Ribble @mribble")]
		[InlineData(15, "LUNARG", "LunarG, Inc.", "Karen Ghavam @KarenGhavam")]
		[InlineData(16, "SAMSUNG", "Samsung Electronics Co., Ltd.", "Alon Or-bach @alonorbach")]
		[InlineData(17, "SEC", "Samsung Electronics Co., Ltd.", "Alon Or-bach @alonorbach")]
		[InlineData(18, "TIZEN", "Samsung Electronics Co., Ltd.", "Alon Or-bach @alonorbach")]
		[InlineData(19, "RENDERDOC", "RenderDoc (renderdoc.org)", "baldurk@baldurk.org")]
		public void VkRegistry_VkTag_Mapped(int index, string name, string author, string contact)
		{
			var subject = Fixture.VkRegistry;

			subject.Tags[index].Name.Should().Be(name);
			subject.Tags[index].Author.Should().Be(author);
			subject.Tags[index].Contact.Should().Be(contact);
		}

		private SpecFixture Fixture { get; set; }
	}
}
