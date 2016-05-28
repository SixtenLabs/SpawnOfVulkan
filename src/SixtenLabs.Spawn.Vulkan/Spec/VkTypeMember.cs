using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixtenLabs.Spawn.Vulkan.Spec
{
	public class VkTypeMember
	{
		public string Name { get; set; }

		public string Type { get; set; }

		/// <summary>
		/// Handle the case where it is array with API Constant as the size of the array
		/// 
		/// <member>
    ///    <type>char</type> <name>deviceName</name>[<enum>VK_MAX_PHYSICAL_DEVICE_NAME_SIZE</enum>]
    ///  </member>
		/// 
		/// </summary>
		public string Enum { get; set; }

		public bool ReturnedOnly { get; set; }

		public bool Optional { get; set; }

		public string Len { get; set; }

		public bool NoAutoValidity { get; set; }
	}
}
