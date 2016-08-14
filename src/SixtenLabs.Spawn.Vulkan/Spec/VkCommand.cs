using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixtenLabs.Spawn.Vulkan.Spec
{
	public class VkCommand
	{
		public string Name { get; set; }

		public string Type { get; set; }

		public IList<VkCommandParameter> Parameters { get; set; }

		public string SuccessCodes { get; set; }

		public string ErrorCodes { get; set; }

		public IList<VkUsage> Validity { get; set; }
	}
}
