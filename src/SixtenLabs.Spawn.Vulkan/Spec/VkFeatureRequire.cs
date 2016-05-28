using System.Collections.Generic;

namespace SixtenLabs.Spawn.Vulkan.Spec
{
	public class VkFeatureRequire
	{
		public string Comment { get; set; }

		public IList<VkFeatureRequireType> Types { get; } = new List<VkFeatureRequireType>();

		public IList<VkFeatureRequireEnum> Enums { get; } = new List<VkFeatureRequireEnum>();

		public IList<VkFeatureRequireCommand> Commands { get; } = new List<VkFeatureRequireCommand>();
	}
}
