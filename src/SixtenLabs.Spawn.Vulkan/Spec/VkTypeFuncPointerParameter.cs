using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixtenLabs.Spawn.Vulkan.Spec
{
	public class VkTypeFuncPointerParameter
	{
		public string Name { get; set; }

		public bool IsPointer { get; set; }

		public bool IsConst { get; set; }

		public string ReturnType { get; set; }
	}
}
