using Xunit;
using FluentAssertions;
using System.Xml.Linq;

namespace SixtenLabs.Spawn.Vulkan.Tests
{
	public class xmlTest
	{
		public xmlTest()
		{
			registryXml = XElement.Load("https://raw.githubusercontent.com/KhronosGroup/Vulkan-Docs/1.0/src/spec/vk.xml");
		}

		private XElement registryXml { get; set; }

		[Fact]
		public void Comment()
		{
			var subject = registryXml;

			var actual = subject.Element("comment").GetInnerXml();

			actual.Should().NotBeNull();
		}

		[Fact]
		public void VendorIds()
		{
			var subject = registryXml;

			var actual = subject.Element("vendorids").Elements("vendorid");

			actual.Should().NotBeNull();
		}

		[Fact]
		public void Feature()
		{
			var subject = registryXml;

			var actual = subject.Element("feature").Elements("require");

			actual.Should().NotBeNull();
		}
	}
}
