using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SixtenLabs.SpawnOfVulkan
{
	public static partial class Vk
	{

		static Vk()
		{

		}

		public static void Test()
		{
			VulkanLibraryHandle = NativeLibrary.LoadLibrary("vulkan-1.dll");

			if (VulkanLibraryHandle != IntPtr.Zero)
			{
				GetInstanceProcAddr = MarshalDelegate<GetInstanceProcAddrDelegate>("vkGetInstanceProcAddr");
			}
			else
			{
				throw new InvalidOperationException("Could not load vulkan interop...");
			}
		}

		private static T MarshalDelegate<T>(string name)
		{
			var delegateHandle = NativeLibrary.GetProcAddress(VulkanLibraryHandle, name);

			if (delegateHandle != IntPtr.Zero)
			{
				return Marshal.GetDelegateForFunctionPointer<T>(delegateHandle);
			}
			else
			{
				return default(T);
			}
		}
				
		private static IntPtr VulkanLibraryHandle { get; set; }

		public static GetInstanceProcAddrDelegate GetInstanceProcAddr { get; set; }


		//public static T GetVulkanCommand<T>(Instance instance, string name)
		//{
		//	var commandHandle = GetInstanceProcAddr(instance, name);

		//	return MarshalDelegate<T>(name);
		//}
	}
}
