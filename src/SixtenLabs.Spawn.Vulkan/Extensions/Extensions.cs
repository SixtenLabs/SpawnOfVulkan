using System;
using System.Collections.Generic;

namespace SixtenLabs.Spawn.Vulkan
{
	public static class Extensions
	{
		public static string FormatFlagValue(this byte position)
		{
			return string.Format("0x{0:X}", 1 << position);
		}

		public static string FirstLetterToLowercase(this string word)
		{
			return char.ToLowerInvariant(word[0]) + word.Substring(1);
		}

		public static string TranslateVulkanName(this string vulkanName)
		{
			var name = vulkanName;

			if (vulkanName.StartsWith("VK_"))
			{
				name = vulkanName.Substring(3, name.Length - 3);
			}
			else if (vulkanName.ToLower().StartsWith("vk") )
			{
				name = vulkanName.Remove(0, 2);
			}
			
			if (name.Contains("FlagBits"))
			{
				name = name.Replace("FlagBits", "Flags");
			}

			if (name.Contains("_"))
			{
				name = name.ConvertToTitleCase('_');
			}

			foreach (var nameCorrection in NameCorrections)
			{
				if (name.Contains(nameCorrection.Key))
				{
					name = name.Replace(nameCorrection.Key, nameCorrection.Value);
				}
			}

			return name;
		}
				
		private static IDictionary<string, string> NameCorrections { get; } = new Dictionary<string, string>()
		{
			{ "API", "Api" },
			{ "EXT", "Ext" },
			{ "KHR", "Khr" },
		};
	}
}
