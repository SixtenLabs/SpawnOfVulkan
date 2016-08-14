using System.Collections.Generic;

namespace SixtenLabs.Spawn.Vulkan.Spec
{
	public class VkRegistry
	{
		public string Comments { get; set; }

		public IList<VkVendorId> VendorIds { get; set; }

		public IList<VkTag> Tags { get; set; }

		public IList<VkTypeInclude> Includes { get; set; }

		public IList<VkTypeRequires> Requires { get; set; }

		public IList<VkTypeDefine> Defines { get; set; }

		public IList<VkTypeBaseType> BaseTypes { get; set; }

		public IList<VkTypeBitmask> Bitmasks { get; set; }

		public IList<VkTypeHandle> Handles { get; set; }

		public IList<VkTypeEnum> TypeEnums { get; set; }

		public IList<VkTypeFuncPointer> TypeFuncPointers { get; set; }

		public IList<VkTypeStruct> TypeStructs { get; set; }

		public IList<VkTypeUnion> TypeUnions { get; set; }

		public VkConstant Constants { get; set; }

		public IList<VkEnum> Enums { get; set; }

		public IList<VkCommand> Commands { get; set; }

		public VkFeature Feature { get; set; }

		public IList<VkExtension> Extensions { get; set; }
	}
}
