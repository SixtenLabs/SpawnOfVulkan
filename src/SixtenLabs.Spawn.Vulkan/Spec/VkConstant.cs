using System.Collections.Generic;

namespace SixtenLabs.Spawn.Vulkan.Spec
{
	public class VkConstant
	{
		public string Name { get; set; }

		public IList<VkConstantValue> Values { get; } = new List<VkConstantValue>();
	}
}
