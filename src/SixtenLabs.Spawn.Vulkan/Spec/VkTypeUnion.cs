using System.Collections.Generic;

namespace SixtenLabs.Spawn.Vulkan.Spec
{
	public class VkTypeUnion
	{
		public string Name { get; set; }

		public bool IsReturnedOnly { get; set; }

		public IList<VkTypeUnionMember> Members { get; set; }

		public IList<VkUsage> Validity { get; set; }
	}
}
