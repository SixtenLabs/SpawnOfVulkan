using Xunit;
using FluentAssertions;
using NSubstitute;

namespace SixtenLabs.Spawn.Vulkan.Tests
{
	public class VulkanSpecTests
	{
		private VulkanSpec SubjectUnderTest()
		{
			MockSettings = Substitute.For<IGeneratorSettings>();
			MockWebClientFactory = Substitute.For<IWebClientFactory>();
			MockFileLoader = Substitute.For<XmlFileLoader<registry>>(MockSettings, MockWebClientFactory);

			return new VulkanSpec(MockFileLoader);
		}

		[Fact]
		public void Constructor_Instance_NotNull()
		{
			var subject = SubjectUnderTest();

			subject.Should().NotBeNull();
		}

		private XmlFileLoader<registry> MockFileLoader { get; set; }

		private IGeneratorSettings MockSettings { get; set; }

		private IWebClientFactory MockWebClientFactory { get; set; }
	}
}
