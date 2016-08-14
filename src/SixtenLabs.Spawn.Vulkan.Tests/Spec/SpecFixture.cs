using AutoMapper;
using SixtenLabs.Spawn.Vulkan.Spec;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SixtenLabs.Spawn.Vulkan.Tests
{
	public class SpecFixture : IDisposable
	{
		public SpecFixture()
		{
			SetupMapper();
			LoadRegistry();
		}

		private void SetupMapper()
		{
			var config = new MapperConfiguration(cfg =>
			{
				cfg.AddProfile(new VkSpecMapper());
				cfg.AddProfile(new RegistryCommandMapper());
				cfg.AddProfile(new RegistryEnumMapper());
				cfg.AddProfile(new RegistryFeatureMapper());
				cfg.AddProfile(new RegistryTypeMapper());
				cfg.AddProfile(new SpecTypeMapper());
			});

			config.AssertConfigurationIsValid();

			SpecMapper = config.CreateMapper();
		}
		
		private void LoadRegistry()
		{
			//Registry = XElement.Load("Spec/vk.xml");
			Registry = XElement.Load("https://raw.githubusercontent.com/KhronosGroup/Vulkan-Docs/1.0/src/spec/vk.xml");

			VkRegistry = SpecMapper.Map<VkRegistry>(Registry);
		}

		public void Dispose()
		{
		}

		public IMapper SpecMapper { get; set; }

		public XElement Registry { get; set; }

		public VkRegistry VkRegistry { get; set; }
	}
}
