using System.Collections.Generic;

namespace SixtenLabs.Spawn.Vulkan.Spec
{
	public class VkExtension
	{
		public string Name { get; set; }

		public string Number { get; set; }

		public string Supported { get; set; }

		public string Protect { get; set; }

		public string Author { get; set; }

		public string Contact { get; set; }

		public IList<VkExtensionEnum> Enums { get; set; }

		public IList<VkExtensionType> Types { get; set; }

		public IList<VkExtensionCommand> Commands { get; set; }

		public IList<VkExtensionUsage> Usages { get; set; }
	}
}
