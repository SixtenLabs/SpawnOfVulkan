﻿using System;

namespace SixtenLabs.Vulkan.Generator
{
	class Program
	{
		static void Main(string[] args)
		{
			Bootstrapper.Bootstrap();
			GenerateVulkanBindings();

			Console.ReadLine();
		}

		private static void GenerateVulkanBindings()
		{
			var generator = Bootstrapper.GetRoot();

			generator.Initialize();
			generator.MapTypes();
			generator.Rewrite();
			generator.Build();
			generator.Generate();
		}

		private static VulkanBootstrapper Bootstrapper { get; } = new VulkanBootstrapper();

	}
}
