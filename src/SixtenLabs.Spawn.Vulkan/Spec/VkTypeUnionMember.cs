namespace SixtenLabs.Spawn.Vulkan.Spec
{

	public class VkTypeUnionMember
	{
		public string Name { get; set; }

		public string ReturnType { get; set; }

		public bool IsPointer { get; set; }

		public bool IsConst { get; set; }

		public string Optional { get; set; }

		public string NoAutoValidity { get; set; }

		public string Len { get; set; }

		public bool IsArray { get; set; }

		public string ArrayCount { get; set; }

		/// <summary>
		/// Get from <!-- comments --> at end of member definition
		/// </summary>
		public string Comment { get; set; }
	}
}
