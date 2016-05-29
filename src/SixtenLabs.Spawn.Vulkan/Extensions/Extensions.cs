using System;
using System.Collections.Generic;

namespace SixtenLabs.Spawn.Vulkan
{
	public static class Extensions
	{
		public static string FormatFlagValue(this string position)
		{
			var asByte = Convert.ToByte(position);

			return string.Format("0x{0:X}", 1 << asByte);
		}

		public static string FirstLetterToLowercase(this string word)
		{
			return char.ToLowerInvariant(word[0]) + word.Substring(1);
		}

		public static string GetStringBetweenBrackets(this string text)
		{
			return text.Split(new string[] { "[" }, StringSplitOptions.None)[1].Split(']')[0].Trim();
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

			if(name == "object")
			{
				name = "Handle";
			}

			foreach (var nameCorrection in NameCorrections)
			{
				if (name.Contains(nameCorrection.Key))
				{
					name = name.Replace(nameCorrection.Key, nameCorrection.Value);
				}
			}

			if(char.IsLower(name[0]))
			{
				name = name.UpperCaseFirstLetter();
			}

			return name;
		}
		
		public static string UpperCaseFirstLetter(this string text)
		{
			if (string.IsNullOrEmpty(text))
			{
				return string.Empty;
			}

			return char.ToUpper(text[0]) + text.Substring(1);
		} 
	
		private static IDictionary<string, string> NameCorrections { get; } = new Dictionary<string, string>()
		{
			{ "API", "Api" },
			{ "EXT", "Ext" },
			{ "KHR", "Khr" },
		};
	}
}
