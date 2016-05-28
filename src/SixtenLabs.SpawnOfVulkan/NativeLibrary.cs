using System;
using System.Runtime.InteropServices;

namespace SixtenLabs.SpawnOfVulkan
{
	public static class NativeLibrary
	{
		[DllImport("kernel32.dll")]
		public static extern IntPtr LoadLibrary(string dllToLoad);

		[DllImport("kernel32.dll")]
		public static extern IntPtr GetProcAddress(IntPtr hModule, string procedureName);

		[DllImport("kernel32.dll")]
		public static extern bool FreeLibrary(IntPtr hModule);

		//public static string GetLibraryPathname(string filename)
		//{
		//	// If 64-bit process, load 64-bit DLL
		//	bool is64bit = Environment.Is64BitProcess;

		//	string prefix = "Win32";

		//	if (is64bit)
		//	{
		//		prefix = "x64";
		//	}

		//	var lib1 = prefix + @"\" + filename;

		//	return lib1;
		//}
	}
}
