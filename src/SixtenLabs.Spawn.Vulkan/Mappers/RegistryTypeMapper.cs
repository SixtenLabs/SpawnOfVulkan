using AutoMapper;
using SixtenLabs.Spawn.CSharp;
using System.Linq;

namespace SixtenLabs.Spawn.Vulkan
{
	public class RegistryTypeMapper : Profile
	{
		protected override void Configure()
		{
			CreateMap<registryType, StructDefinition>()
				.ForMember(dest => dest.SpecName, opt => opt.MapFrom(m => MapSpecName(m)))
				.ForMember(dest => dest.SpecDerivedType, opt => opt.MapFrom(m => m.parent))
				.ForMember(dest => dest.Comments, opt => opt.MapFrom(m => MapComments(m.comment)))
				.ForMember(dest => dest.NeedsMarshalling, opt => opt.MapFrom(m => MapNeedsMarshalling(m)))
				.ForMember(dest => dest.Fields, opt => opt.MapFrom(m => m.Items.Where(x => x.GetType() == typeof(registryTypeMember))));
	
			CreateMap<registryTypeMember, FieldDefinition>()
				.ForMember(dest => dest.SpecName, opt => opt.MapFrom(m => m.name))
				.ForMember(dest => dest.SpecReturnType, opt => opt.MapFrom(m => m.type))
				.ForMember(dest => dest.ReturnTypeIsArray, opt => opt.MapFrom(m => MapReturnTypeIsArray(m)))
				.ForMember(dest => dest.Tag, opt => opt.MapFrom(m => MapArraySizeName(m)))
				.ForMember(dest => dest.SpecType, opt => opt.MapFrom(m => m.@type));
		}

		private string MapSpecName(registryType rt)
		{
			if(rt.category == "struct")
			{
				return rt.name;
			}
			else if(rt.category == "handle")
			{
				return rt.Items[1] as string;
			}
			else if (rt.category == "union")
			{
				return rt.name as string;
			}
			else
			{
				return null;
			}
		}

		private bool MapNeedsMarshalling(registryType rt)
		{
			foreach (var member in rt.Items.Where(x => x.GetType() == typeof(registryTypeMember)).Cast<registryTypeMember>())
			{
				if (member.Text != null && (member.Text[0].Contains("*") || member.Text[0].StartsWith("[")))
				{
					return true;
				}
			}

			return false;
		}

		private bool MapReturnTypeIsArray(registryTypeMember rtm)
		{
			return rtm.Text != null && rtm.Text[0].StartsWith("[");
		}

		private string MapArraySizeName(registryTypeMember rtm)
		{
			string arraySizeName = null;

			if (rtm.@enum != null)
			{
				arraySizeName = rtm.@enum;
			}
			else if(rtm.Text != null)
			{
				arraySizeName = rtm.Text[0].Replace("[", "").Replace("]", "");
			}
			// How to get the arraySize...either from generated API

			return arraySizeName;
		}

		private CommentDefinition MapComments(string comment)
		{
			var commentDefinition = new CommentDefinition();

			if (!string.IsNullOrEmpty(comment))
			{
				commentDefinition.CommentLines.Add(comment);
			}

			return commentDefinition;
		}
	}
}
