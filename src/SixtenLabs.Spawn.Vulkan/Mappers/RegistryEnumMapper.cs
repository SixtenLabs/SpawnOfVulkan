using AutoMapper;
using SixtenLabs.Spawn.CSharp;
using SixtenLabs.Spawn.Vulkan.Spec;
using System;

namespace SixtenLabs.Spawn.Vulkan
{
	public class RegistryEnumMapper : Profile
	{
		public RegistryEnumMapper()
		{
			ConfigureApiConstantsMapping();
			ConfigureEnumMapping();
		}

		/// <summary>
		/// There is one oddball defined enum that actually need to be mapped
		/// as a static class with constant values.
		/// </summary>
		private void ConfigureApiConstantsMapping()
		{
			CreateMap<VkConstant, ClassDefinition>()
				.ForMember(dest => dest.SpecName, opt => opt.MapFrom(m => m.Name))
				.ForMember(dest => dest.Fields, opt => opt.MapFrom(m => m.Values))
				.ForMember(dest => dest.SpecDerivedType, opt => opt.Ignore())
				.ForMember(dest => dest.DerivedType, opt => opt.Ignore())
				.ForMember(dest => dest.Methods, opt => opt.Ignore())
				.ForMember(dest => dest.Attributes, opt => opt.Ignore())
				.ForMember(dest => dest.Comments, opt => opt.Ignore())
				.ForMember(dest => dest.SpecReturnType, opt => opt.Ignore())
				.ForMember(dest => dest.TranslatedReturnType, opt => opt.Ignore())
				.ForMember(dest => dest.ModifierDefinitions, opt => opt.Ignore())
				.ForMember(dest => dest.TranslatedName, opt => opt.Ignore())
				.ForMember(dest => dest.Tag, opt => opt.Ignore());

			CreateMap<VkConstantValue, FieldDefinition>()
				.ForMember(dest => dest.SpecName, opt => opt.MapFrom(m => m.Name))
				.ForMember(dest => dest.SpecReturnType, opt => opt.MapFrom(m => ProcessReturnType(m)))
				.ForMember(dest => dest.TranslatedReturnType, opt => opt.MapFrom(m => ProcessReturnType(m)))
				.ForMember(dest => dest.DefaultValue, opt => opt.MapFrom(m => ProcessFieldReturnValue(m)))
				.ForMember(dest => dest.DefaultValue, opt => opt.Ignore())
				.ForMember(dest => dest.ReturnTypeIsArray, opt => opt.Ignore())
				.ForMember(dest => dest.ArraySize, opt => opt.Ignore())
				.ForMember(dest => dest.Attributes, opt => opt.Ignore())
				.ForMember(dest => dest.SpecType, opt => opt.Ignore())
				.ForMember(dest => dest.TranslatedType, opt => opt.Ignore())
				.ForMember(dest => dest.TranslatedValue, opt => opt.Ignore())
				.ForMember(dest => dest.Parameters, opt => opt.Ignore())
				.ForMember(dest => dest.Block, opt => opt.Ignore())
				.ForMember(dest => dest.SpecReturnType, opt => opt.Ignore())
				.ForMember(dest => dest.TranslatedReturnType, opt => opt.Ignore())
				.ForMember(dest => dest.ModifierDefinitions, opt => opt.Ignore())
				.ForMember(dest => dest.TranslatedName, opt => opt.Ignore())
				.ForMember(dest => dest.SpecValue, opt => opt.Ignore())
				.ForMember(dest => dest.Tag, opt => opt.Ignore());
		}

		private void ConfigureEnumMapping()
		{
			CreateMap<VkEnum, EnumDefinition>()
				.ForMember(dest => dest.SpecName, opt => opt.MapFrom(m => m.Name))
				.ForMember(dest => dest.HasFlags, opt => opt.MapFrom(m => m.IsFlags))
				.ForMember(dest => dest.Members, opt => opt.MapFrom(m => m.Values))
				.ForMember(dest => dest.BaseType, opt => opt.Ignore())
				.ForMember(dest => dest.Comments, opt => opt.Ignore())
				.ForMember(dest => dest.SpecReturnType, opt => opt.Ignore())
				.ForMember(dest => dest.TranslatedReturnType, opt => opt.Ignore())
				.ForMember(dest => dest.ModifierDefinitions, opt => opt.Ignore())
				.ForMember(dest => dest.TranslatedName, opt => opt.Ignore())
				.ForMember(dest => dest.Tag, opt => opt.Ignore());

			CreateMap<VkEnumValue, EnumMemberDefinition>()
				.ForMember(dest => dest.SpecName, opt => opt.MapFrom(m => m.Name))
				.ForMember(dest => dest.Comments, opt => opt.MapFrom(m => AddComment(m.Comment)))
				.ForMember(dest => dest.Value, opt => opt.MapFrom(m => ProcessEnumValue(m)))
				.ForMember(dest => dest.TranslatedName, opt => opt.Ignore())
				.ForMember(dest => dest.Tag, opt => opt.Ignore());
		}

		private string ProcessEnumValue(VkEnumValue enumValue)
		{
			if(!string.IsNullOrEmpty(enumValue.BitPos))
			{
				return enumValue.BitPos.FormatFlagValue();
			}
			else
			{
				return enumValue.Value;
			}
		}

		private LiteralDefinition ProcessFieldReturnValue(VkConstantValue returnValue)
		{
			LiteralDefinition value = null;

			if (!string.IsNullOrEmpty(returnValue.Value))
			{
				if (returnValue.Value.Contains("f"))
				{
					value = new LiteralDefinition() { Value = returnValue.Value.Replace("f", ""), LiteralType = typeof(float) };
				}
				else if (returnValue.Value.Contains("(~0U)"))
				{
					value = new LiteralDefinition() { Value = "uint.MaxValue", LiteralType = typeof(uint) };
				}
				else if (returnValue.Value.Contains("(~0ULL)"))
				{
					value = new LiteralDefinition() { Value = "ulong.MaxValue", LiteralType = typeof(ulong) };
				}
				else
				{
					value = new LiteralDefinition() { Value = returnValue.Value, LiteralType = typeof(int) };
				}
			}

			return value;
		}

		private string ProcessReturnType(VkConstantValue ree)
		{
			string type = null;

			if (!string.IsNullOrEmpty(ree.Value))
			{
				if (ree.Value.Contains("f"))
				{
					type = "float";
				}
				else if (ree.Value.Contains("(~0U)"))
				{
					type = "uint";
				}
				else if (ree.Value.Contains("(~0ULL)"))
				{
					type = "ulong";
				}
				else
				{
					type = "uint";
				}
			}

			return type;
		}

		private CommentDefinition AddComment(string comment)
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
