using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixtenLabs.Spawn.Vulkan.Spec
{
	/// <summary>
	/// 
	/// This represents a header file that is used in the c/c++ versions of vulkan.
	/// We do not use these header files.
	/// We are going to capture this from the spec just in case we need this info someday.
	/// 
	/// </summary>
	public class VkTypeInclude
	{
		/// <summary>
		/// The name is either in the attribute on the type or as a <name>xxxx</name> node in the text.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// This is always include
		/// </summary>
		public string Category { get; set; }

		/// <summary>
		/// This is really not needed but we will store the complete text value here.
		/// </summary>
		public string Value { get; set; }

		/// <summary>
		/// All includes that do not match below are WSI extensions
		/// </summary>
		public bool IsWsiExtension
		{
			get
			{
				return Name != "vk_platform";
			}
		}
	}
}
