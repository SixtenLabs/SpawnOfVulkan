using System.Collections.Generic;

namespace SixtenLabs.Spawn.Vulkan.Spec
{
	public class VkTypeStruct
	{
		public string Name { get; set; }

		public bool IsReturnedOnly { get; set; }

		public IList<VkTypeStructMember> Members { get; set; }

		public IList<VkUsage> Validity { get; set; }
	}
}
