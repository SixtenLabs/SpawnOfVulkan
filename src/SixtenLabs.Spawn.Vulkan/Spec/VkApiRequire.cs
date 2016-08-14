using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixtenLabs.Spawn.Vulkan.Spec
{
	public class VkApiRequire
	{
		public string Comment { get; set; }

		public IList<VkApiRequireMember> Members { get; set; }
	}
}
