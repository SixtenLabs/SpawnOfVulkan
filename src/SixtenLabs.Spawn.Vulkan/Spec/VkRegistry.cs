using System.Collections.Generic;

namespace SixtenLabs.Spawn.Vulkan.Spec
{
	public class VkRegistry
	{
		public string Comments { get; set; }

		public IList<VkVendorId> VendorIds { get; } = new List<VkVendorId>();

		public IList<VkTag> Tags { get; } = new List<VkTag>();

		public IList<VkTypeInclude> Includes { get; } = new List<VkTypeInclude>();

		public IList<VkTypeRequires> Requires { get; } = new List<VkTypeRequires>();

		public IList<VkTypeDefine> Defines { get; } = new List<VkTypeDefine>();

		public IList<VkTypeBaseType> BaseTypes { get; } = new List<VkTypeBaseType>();

		public IList<VkTypeBitmask> Bitmasks { get; } = new List<VkTypeBitmask>();

		public IList<VkTypeHandle> Handles { get; } = new List<VkTypeHandle>();

		public IList<VkTypeEnum> TypeEnums { get; } = new List<VkTypeEnum>();

		public IList<VkTypeFuncPointer> TypeFuncPointers { get; } = new List<VkTypeFuncPointer>();

		public IList<VkTypeStruct> TypeStructs { get; } = new List<VkTypeStruct>();

		public IList<VkTypeUnion> TypeUnions { get; } = new List<VkTypeUnion>();

		public VkConstants Constants { get; set; }

		public IList<VkEnum> Enums { get; } = new List<VkEnum>();

		public IList<VkCommand> Commands { get; } = new List<VkCommand>();

		public VkFeature Feature { get; set; }

		public IList<VkExtension> Extensions { get; } = new List<VkExtension>();
	}
}
