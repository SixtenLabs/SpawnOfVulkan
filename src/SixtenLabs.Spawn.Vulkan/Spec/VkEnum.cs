using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixtenLabs.Spawn.Vulkan.Spec
{
	public class VkEnum
	{
		public string Name { get; set; }

		public string Type { get; set; }

		public string Comment { get; set; }

		public bool IsFlags
		{
			get
			{
				return Type == "bitmask";
			}
		}

		public IList<VkEnumValue> Values { get; } = new List<VkEnumValue>();
	}
}
