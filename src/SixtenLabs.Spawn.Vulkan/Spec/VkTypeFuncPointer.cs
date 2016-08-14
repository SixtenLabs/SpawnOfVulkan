using System.Collections.Generic;

namespace SixtenLabs.Spawn.Vulkan.Spec
{
	public class VkTypeFuncPointer
	{
		public string Name { get; set; }

		public string ReturnType { get; set; }

		public IList<VkTypeFuncPointerParameter> Parameters { get; set; }
	}
}
