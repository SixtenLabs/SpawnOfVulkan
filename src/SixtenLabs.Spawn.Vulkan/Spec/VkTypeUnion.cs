using System.Collections.Generic;

namespace SixtenLabs.Spawn.Vulkan.Spec
{
	public class VkTypeUnion
	{
		public string Name { get; set; }

		public bool IsReturnedOnly { get; set; }

		public IList<VkTypeStructMember> Members { get; } = new List<VkTypeStructMember>();

		public IList<VkUsage> Validity { get; } = new List<VkUsage>();
	}
}
