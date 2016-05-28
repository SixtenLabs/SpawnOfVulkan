using SixtenLabs.Spawn.Vulkan.Spec;

namespace SixtenLabs.Spawn.Vulkan
{
	public class VulkanSpec : SpawnSpec<VkRegistry>
	{
		public VulkanSpec(XmlFileLoader<VkRegistry> xmlFileLoader)
			: base(xmlFileLoader)
		{
		}
	}
}
