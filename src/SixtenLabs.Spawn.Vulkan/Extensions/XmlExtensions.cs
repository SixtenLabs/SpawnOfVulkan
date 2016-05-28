using System.Xml.Linq;

namespace SixtenLabs.Spawn.Vulkan
{
	public static class XmlExtensions
	{
		public static string GetInnerXml(this XNode node)
		{
			using (var reader = node.CreateReader())
			{
				reader.MoveToContent();
				return reader.ReadInnerXml();
			}
		}
	}
}
