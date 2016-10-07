using AutoMapper;
using SixtenLabs.Spawn.Vulkan.Spec;

namespace SixtenLabs.Spawn.Vulkan
{
	public class VulkanSpec : SpawnSpec<VkRegistry>
	{
		public VulkanSpec(XmlFileLoader xmlFileLoader, ISpecMapper<VkRegistry> specMapper, IDefinitionDictionary definitionDictionary)
			: base(xmlFileLoader, specMapper, definitionDictionary)
		{
		}
	}
}
