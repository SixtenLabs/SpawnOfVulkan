using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixtenLabs.Spawn.Vulkan.Spec
{
	public class VkCommandParameter
	{
		public string Name { get; set; }

		public string ReturnType { get; set; }

		public bool IsConst { get; set; }

		/// <summary>
		/// Try to understand how Tanagra is handling this with pointer ranks.
		/// need to understand how to convert these properly.
		/// </summary>
		public int PointerRank { get; set; }

		public string Len { get; set; }

		public string IsOptional { get; set; }

		public string ExternSync { get; set; }
	}
}
