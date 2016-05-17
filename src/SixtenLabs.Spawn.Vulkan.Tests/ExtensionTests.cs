using Xunit;
using FluentAssertions;

namespace SixtenLabs.Spawn.Vulkan.Tests
{
	public class ExtensionTests
	{
		[Fact]
		public void xx()
		{
			var subject = "Text";

			var actual = subject.FirstLetterToLowercase();

			actual.Should().Be("text");
		}
	}
}
