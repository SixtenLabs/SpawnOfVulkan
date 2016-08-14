using System.Collections.Generic;

namespace SixtenLabs.Spawn.Vulkan.Spec
{
	public class VkFeatureRequire
	{
		public string Comment { get; set; }

		public IList<VkFeatureRequireType> Types { get; set; }

		public IList<VkFeatureRequireEnum> Enums { get; set; }

		public IList<VkFeatureRequireCommand> Commands { get; set; }
	}
}
