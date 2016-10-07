using AutoMapper;
using SixtenLabs.Spawn.Vulkan.Spec;
using System;
using System.Xml.Linq;
using SixtenLabs.Spawn.CSharp;
using NSubstitute;

namespace SixtenLabs.Spawn.Vulkan.Tests
{
	public class SpecFixture : IDisposable
	{
		public SpecFixture()
		{
      Setup();

    }

    private void Setup()
    {
      SetupMapper();
      LoadRegistry();
    }

		private void SetupMapper()
		{
      var definitionDictionary = Substitute.For<IDefinitionDictionary>();
      definitionDictionary.GetTranslatedName(Arg.Any<string>()).Returns("MockName");

      var config = new MapperConfiguration(cfg =>
			{
				cfg.AddProfile(new VkSpecMapper());
				cfg.AddProfile(new RegistryCommandMapper());
				cfg.AddProfile(new RegistryEnumMapper());
				cfg.AddProfile(new RegistryFeatureMapper());
				cfg.AddProfile(new RegistryTypeMapper());
				cfg.AddProfile(new SpecTypeMapper());
        cfg.CreateMap<string, DefinitionName>().ConvertUsing(new DefinitionNameTypeConverter(definitionDictionary));
      });

			config.AssertConfigurationIsValid();

			SpecMapper = config.CreateMapper();

      VulkanSpecMapper = new VulkanSpecMapper(definitionDictionary);

      SpawnSpec = new VulkanSpec(new XmlFileLoader(MockParseSettings, MockWebClientFactory), VulkanSpecMapper, definitionDictionary);
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

    public ISpecMapper<VkRegistry> VulkanSpecMapper { get; set; }

		public XElement Registry { get; set; }

		public VkRegistry VkRegistry { get; set; }

    private IGeneratorSettings MockParseSettings { get; set; }

    private IWebClientFactory MockWebClientFactory { get; set; }

    public VulkanSpec SpawnSpec { get; set; }
	}
}
