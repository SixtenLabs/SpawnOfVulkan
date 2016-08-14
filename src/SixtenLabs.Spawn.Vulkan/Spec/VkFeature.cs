using System.Collections.Generic;

namespace SixtenLabs.Spawn.Vulkan.Spec
{
	public class VkFeature
	{
		public string Api { get; set; }

		public string Name { get; set; }

		public string Number { get; set; }

		public IList<VkFeatureRequire> Requires { get; set; }
	}
}
