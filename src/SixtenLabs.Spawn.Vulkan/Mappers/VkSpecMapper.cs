using AutoMapper;
using SixtenLabs.Spawn.Vulkan.Spec;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SixtenLabs.Spawn.Vulkan
{
	/// <summary>
	/// This is used to map vk.xml to c# objects.
	/// </summary>
	public class VkSpecMapper : Profile
	{
		private void ConfigureVkRegistry()
		{
			CreateMap<XElement, VkRegistry>()
				.ForMember(dest => dest.Comments, opt => opt.MapFrom(m => m.Value))
				.ForMember(dest => dest.VendorIds, opt => opt.MapFrom(m => m.Element("vendorids").Elements("vendorid")))
				.ForMember(dest => dest.Tags, opt => opt.MapFrom(m => m.Element("tags").Elements("tag")))
				.ForMember(dest => dest.Includes, opt => opt.MapFrom(m => GetTypesByCategory(m, "include")))
				.ForMember(dest => dest.Requires, opt => opt.MapFrom(m => GetTypesByAttribute(m, "requires")))
				.ForMember(dest => dest.Defines, opt => opt.MapFrom(m => GetTypesByCategory(m, "define")))
				.ForMember(dest => dest.BaseTypes, opt => opt.MapFrom(m => GetTypesByCategory(m, "basetype")))
				.ForMember(dest => dest.Bitmasks, opt => opt.MapFrom(m => GetTypesByCategory(m, "bitmask")))
				.ForMember(dest => dest.Handles, opt => opt.MapFrom(m => GetTypesByCategory(m, "handle")))
				.ForMember(dest => dest.TypeEnums, opt => opt.MapFrom(m => GetTypesByCategory(m, "enum")))
				.ForMember(dest => dest.TypeFuncPointers, opt => opt.MapFrom(m => GetTypesByCategory(m, "funcpointer")))
				.ForMember(dest => dest.TypeStructs, opt => opt.MapFrom(m => GetTypesByCategory(m, "struct")))
				.ForMember(dest => dest.TypeUnions, opt => opt.MapFrom(m => GetTypesByCategory(m, "union")))
				.ForMember(dest => dest.Constants, opt => opt.MapFrom(m => m.Elements("enums").Where(x => x.Attribute("name").Value == "API Constants").FirstOrDefault()))
				.ForMember(dest => dest.Enums, opt => opt.MapFrom(m => m.Elements("enums").Where(x => x.Attribute("name").Value != "API Constants")))
				.ForMember(dest => dest.Commands, opt => opt.MapFrom(m => m.Element("commands").Elements("command")))
				.ForMember(dest => dest.Feature, opt => opt.MapFrom(m => m.Element("feature")))
				.ForMember(dest => dest.Extensions, opt => opt.MapFrom(m => m.Descendants("extension")));
		}

		private void ConfigureVkVendorId()
		{
			CreateMap<XElement, VkVendorId>()
				.ForMember(dest => dest.Name, opt => opt.MapFrom(m => MapAttribute(m, "name")))
				.ForMember(dest => dest.Id, opt => opt.MapFrom(m => MapAttribute(m, "id")))
				.ForMember(dest => dest.Comment, opt => opt.MapFrom(m => MapAttribute(m, "comment")));
		}

		private void ConfigureVkTag()
		{
			CreateMap<XElement, VkTag>()
				.ForMember(dest => dest.Name, opt => opt.MapFrom(m => MapAttribute(m, "name")))
				.ForMember(dest => dest.Author, opt => opt.MapFrom(m => MapAttribute(m, "author")))
				.ForMember(dest => dest.Contact, opt => opt.MapFrom(m => MapAttribute(m, "contact")));
		}

		private void ConfigureVkInclude()
		{
			CreateMap<XElement, VkTypeInclude>()
				.ForMember(dest => dest.Name, opt => opt.MapFrom(m => MapTypeName(m)))
				.ForMember(dest => dest.Category, opt => opt.MapFrom(m => MapAttribute(m, "category")))
				.ForMember(dest => dest.Value, opt => opt.MapFrom(m => m.Value));
		}

		private void ConfigureVkTypeRequires()
		{
			CreateMap<XElement, VkTypeRequires>()
				.ForMember(dest => dest.Name, opt => opt.MapFrom(m => MapTypeName(m)))
				.ForMember(dest => dest.Requires, opt => opt.MapFrom(m => MapAttribute(m, "requires")));
		}

		private void ConfigureVkTypeDefines()
		{
			CreateMap<XElement, VkTypeDefine>()
				.ForMember(dest => dest.Name, opt => opt.MapFrom(m => MapTypeName(m)))
				.ForMember(dest => dest.Value, opt => opt.MapFrom(m => m.Value));
		}

		private void ConfigureVkTypeBaseType()
		{
			CreateMap<XElement, VkTypeBaseType>()
				.ForMember(dest => dest.Name, opt => opt.MapFrom(m => MapBaseTypeName(m)))
				.ForMember(dest => dest.Type, opt => opt.MapFrom(m => MapBaseTypeType(m)))
				.ForMember(dest => dest.Value, opt => opt.MapFrom(m => m.Value));
		}

		private void ConfigureVkTypeBitmask()
		{
			CreateMap<XElement, VkTypeBitmask>()
				.ForMember(dest => dest.Name, opt => opt.MapFrom(m => MapBaseTypeName(m)))
				.ForMember(dest => dest.Type, opt => opt.MapFrom(m => MapBaseTypeType(m)))
				.ForMember(dest => dest.Requires, opt => opt.MapFrom(m => MapAttribute(m, "requires")))
				.ForMember(dest => dest.Category, opt => opt.MapFrom(m => MapAttribute(m, "category")));
		}

		private void ConfigureVkTypeHandle()
		{
			CreateMap<XElement, VkTypeHandle>()
				.ForMember(dest => dest.Name, opt => opt.MapFrom(m => MapBaseTypeName(m)))
				.ForMember(dest => dest.Parent, opt => opt.MapFrom(m => MapAttribute(m, "parent")))
				.ForMember(dest => dest.Type, opt => opt.MapFrom(m => m.Element("type").Value));
		}

		private void ConfigureVkTypeEnum()
		{
			CreateMap<XElement, VkTypeEnum>()
				.ForMember(dest => dest.Name, opt => opt.MapFrom(m => MapAttribute(m, "name")));
		}

		#region TypeFuncPointer

		private void ConfigureVkTypeFuncPointer()
		{
			CreateMap<XElement, VkTypeFuncPointer>()
				.ForMember(dest => dest.Name, opt => opt.MapFrom(m => MapBaseTypeType(m)))
				.ForMember(dest => dest.ReturnType, opt => opt.MapFrom(m => MapFunctionPointerReturnType(m)))
				.ForMember(dest => dest.Parameters, opt => opt.MapFrom(m => m.Elements("type")));
		}

		private void ConfigureVkTypeFuncPointerParameter()
		{
			CreateMap<XElement, VkTypeFuncPointerParameter>()
				.ForMember(dest => dest.Name, opt => opt.MapFrom(m => MapTypeFunctionPointerParameterName(m)))
				.ForMember(dest => dest.IsPointer, opt => opt.MapFrom(m => MapTypeFunctionPointerParameterIsPointer(m)))
				.ForMember(dest => dest.IsConst, opt => opt.MapFrom(m => MapTypeFunctionPointerParameterIsConst(m)))
				.ForMember(dest => dest.ReturnType, opt => opt.MapFrom(m => MapTypeFunctionPointerParameterReturnType(m)));
		}

		private string MapTypeFunctionPointerParameterName(XElement typeElement)
		{
			var name = typeElement.NextNode.ToString();

			var cleanName = name.Replace(" ", "").Replace("*", "").Replace(",", "").Replace(Environment.NewLine, "").Replace(");", "").Replace("const", "");

			return cleanName;
		}

		private bool MapTypeFunctionPointerParameterIsPointer(XElement typeElement)
		{
			var name = typeElement.NextNode.ToString();

			return name.Contains("*");
		}

		private bool MapTypeFunctionPointerParameterIsConst(XElement typeElement)
		{
			var name = typeElement.PreviousNode.ToString();

			return name.Contains("const ");
		}

		private string MapTypeFunctionPointerParameterReturnType(XElement typeElement)
		{
			var name = typeElement.FirstNode.ToString();

			return name;
		}

		#endregion

		#region TypeStructMapping

		private void ConfigureVkTypeStruct()
		{
			CreateMap<XElement, VkTypeStruct>()
				.ForMember(dest => dest.Name, opt => opt.MapFrom(m => MapAttribute(m, "name")))
				.ForMember(dest => dest.IsReturnedOnly, opt => opt.MapFrom(m => MapAttribute(m, "returnedonly")))
				.ForMember(dest => dest.Members, opt => opt.MapFrom(m => m.Elements("member")))
				.ForMember(dest => dest.Validity, opt => opt.MapFrom(m => m.Element("validity").Elements("usage")));
		}

		private void ConfigureVkTypeStructMember()
		{
			CreateMap<XElement, VkTypeStructMember>()
				.ForMember(dest => dest.Name, opt => opt.MapFrom(m => MapTypeStructMemberName(m)))
				.ForMember(dest => dest.ReturnType, opt => opt.MapFrom(m => MapTypeStructMemberReturnType(m)))
				.ForMember(dest => dest.IsConst, opt => opt.MapFrom(m => MapTypeStructMemberIsConst(m)))
				.ForMember(dest => dest.IsPointer, opt => opt.MapFrom(m => MapTypeStructMemberIsPointer(m)))
				.ForMember(dest => dest.Optional, opt => opt.MapFrom(m => MapAttribute(m, "optional")))
				.ForMember(dest => dest.NoAutoValidity, opt => opt.MapFrom(m => MapTypeStructMemberAutoValidity(m)))
				.ForMember(dest => dest.Len, opt => opt.MapFrom(m => MapAttribute(m, "len")))
				.ForMember(dest => dest.IsArray, opt => opt.MapFrom(m => MapTypeStructMemberIsArray(m)))
				.ForMember(dest => dest.ArrayCount, opt => opt.MapFrom(m => MapTypeStructMemberArrayCount(m)))
				.ForMember(dest => dest.Comment, opt => opt.MapFrom(m => MapTypeStructMemberComment(m)));
		}

		private string MapTypeStructMemberName(XElement memberElement)
		{
			return memberElement.Element("name").Value;
		}

		private string MapTypeStructMemberReturnType(XElement memberElement)
		{
			return memberElement.Element("type").Value;
		}

		private bool MapTypeStructMemberIsConst(XElement typeElement)
		{
			var name = typeElement.Value;

			return name.Contains("const");
		}

		private bool MapTypeStructMemberIsPointer(XElement typeElement)
		{
			var name = typeElement.Value;

			return name.Contains("*");
		}

		private string MapTypeStructMemberAutoValidity(XElement typeElement)
		{
			return typeElement.Attribute("noautovalidity")?.Value;
		}

		private bool MapTypeStructMemberIsArray(XElement typeElement)
		{
			var name = typeElement.LastNode.ToString();

			return name.Contains("]");
		}

		private string MapTypeStructMemberArrayCount(XElement typeElement)
		{
			var arraySize = typeElement.Element("enum")?.Value;

			if(arraySize == null)
			{
				var lastNodeString = typeElement.LastNode.ToString();

				if(!string.IsNullOrEmpty(lastNodeString) && lastNodeString.Contains("[") && lastNodeString.Contains("]"))
				{
					arraySize = lastNodeString.GetStringBetweenBrackets();
				}
			}

			return arraySize;
		}

		private string MapTypeStructMemberComment(XElement typeElement)
		{
			var comment = typeElement.NextNode.ToString();

			return comment.Contains("<!--") ? comment.Replace("<!--", "").Replace("-->", "").Trim() : null;
		}

		#endregion

		#region TypeUnion Mapping

		private void ConfigureVkTypeUnion()
		{
			CreateMap<XElement, VkTypeUnion>()
				.ForMember(dest => dest.Name, opt => opt.MapFrom(m => MapAttribute(m, "name")))
				.ForMember(dest => dest.IsReturnedOnly, opt => opt.MapFrom(m => MapAttribute(m, "returnedonly")))
				.ForMember(dest => dest.Members, opt => opt.MapFrom(m => m.Elements("member")))
				.ForMember(dest => dest.Validity, opt => opt.MapFrom(m => m.Element("validity").Elements("usage")));
		}

		private void ConfigureVkTypeUnionMember()
		{
			CreateMap<XElement, VkTypeUnionMember>()
				.ForMember(dest => dest.Name, opt => opt.MapFrom(m => MapTypeStructMemberName(m)))
				.ForMember(dest => dest.ReturnType, opt => opt.MapFrom(m => MapTypeStructMemberReturnType(m)))
				.ForMember(dest => dest.IsConst, opt => opt.MapFrom(m => MapTypeStructMemberIsConst(m)))
				.ForMember(dest => dest.IsPointer, opt => opt.MapFrom(m => MapTypeStructMemberIsPointer(m)))
				.ForMember(dest => dest.Optional, opt => opt.MapFrom(m => MapAttribute(m, "optional")))
				.ForMember(dest => dest.NoAutoValidity, opt => opt.MapFrom(m => MapTypeStructMemberAutoValidity(m)))
				.ForMember(dest => dest.Len, opt => opt.MapFrom(m => MapAttribute(m, "len")))
				.ForMember(dest => dest.IsArray, opt => opt.MapFrom(m => MapTypeStructMemberIsArray(m)))
				.ForMember(dest => dest.ArrayCount, opt => opt.MapFrom(m => MapTypeStructMemberArrayCount(m)))
				.ForMember(dest => dest.Comment, opt => opt.MapFrom(m => MapTypeStructMemberComment(m)));
		}

		#endregion

		#region Constants Mapping

		private void ConfigureConstants()
		{
			CreateMap<XElement, VkConstants>()
				.ForMember(dest => dest.Name, opt => opt.MapFrom(m => m.Attribute("name").Value))
				.ForMember(dest => dest.Values, opt => opt.MapFrom(m => m.Elements("enum")));
		}

		private void ConfigureConstantsValues()
		{
			CreateMap<XElement, VkConstantValue>()
				.ForMember(dest => dest.Name, opt => opt.MapFrom(m => MapAttribute(m, "name")))
				.ForMember(dest => dest.Value, opt => opt.MapFrom(m => MapAttribute(m, "value")));
		}

		#endregion

		#region Enum Mapping

		private void ConfigureEnum()
		{
			CreateMap<XElement, VkEnum>()
				.ForMember(dest => dest.Name, opt => opt.MapFrom(m => m.Attribute("name").Value))
				.ForMember(dest => dest.Type, opt => opt.MapFrom(m => m.Attribute("type").Value))
				.ForMember(dest => dest.Comment, opt => opt.MapFrom(m => MapAttribute(m, "comment")))
				.ForMember(dest => dest.Values, opt => opt.MapFrom(m => m.Elements("enum")));
		}

		private void ConfigureEnumValue()
		{
			CreateMap<XElement, VkEnumValue>()
				.ForMember(dest => dest.Name, opt => opt.MapFrom(m => MapAttribute(m, "name")))
				.ForMember(dest => dest.Value, opt => opt.MapFrom(m => MapAttribute(m, "value")))
				.ForMember(dest => dest.BitPos, opt => opt.MapFrom(m => MapAttribute(m, "bitpos")))
				.ForMember(dest => dest.Comment, opt => opt.MapFrom(m => MapAttribute(m, "comment")));
		}

		#endregion

		#region Command Mapping

		private void ConfigureCommand()
		{
			CreateMap<XElement, VkCommand>()
				.ForMember(dest => dest.Name, opt => opt.MapFrom(m => m.Element("proto").Element("name").Value))
				.ForMember(dest => dest.Type, opt => opt.MapFrom(m => m.Element("proto").Element("type").Value))
				.ForMember(dest => dest.Parameters, opt => opt.MapFrom(m => m.Elements("param")))
				.ForMember(dest => dest.SuccessCodes, opt => opt.MapFrom(m => MapAttribute(m, "successcodes")))
				.ForMember(dest => dest.Validity, opt => opt.MapFrom(m => m.Element("validity").Elements("usage")))
				.ForMember(dest => dest.ErrorCodes, opt => opt.MapFrom(m => MapAttribute(m, "errorcodes")));
		}

		private void ConfigureCommandParameter()
		{
			CreateMap<XElement, VkCommandParameter>()
				.ForMember(dest => dest.Name, opt => opt.MapFrom(m => MapCommandParameterName(m)))
				.ForMember(dest => dest.ReturnType, opt => opt.MapFrom(m => MapCommandParameterReturnType(m)))
				.ForMember(dest => dest.IsConst, opt => opt.MapFrom(m => MapCommandParameterIsConst(m)))
				.ForMember(dest => dest.PointerRank, opt => opt.MapFrom(m => MapCommandParameterPointerRank(m)))
				.ForMember(dest => dest.Len, opt => opt.MapFrom(m => MapAttribute(m, "len")))
				.ForMember(dest => dest.IsOptional, opt => opt.MapFrom(m => MapAttribute(m, "optional")))
				.ForMember(dest => dest.ExternSync, opt => opt.MapFrom(m => MapAttribute(m, "externsync")));
				
		}

		private string MapCommandParameterName(XElement typeElement)
		{
			return typeElement.Element("name").Value;
		}

		private string MapCommandParameterReturnType(XElement typeElement)
		{
			return typeElement.Element("type").Value;
		}

		private bool MapCommandParameterIsConst(XElement typeElement)
		{
			var name = typeElement.Value;

			return name.Contains("const");
		}

		private int MapCommandParameterPointerRank(XElement typeElement)
		{
			var name = typeElement.ToString();

			return name.Contains("*") ? 1 : 0;
		}

		#endregion

		#region Extensions Mapping

		private void ConfigureVkExtensions()
		{
			CreateMap<XElement, VkExtension>()
				.ForMember(dest => dest.Name, opt => opt.MapFrom(m => MapAttribute(m, "name")))
				.ForMember(dest => dest.Number, opt => opt.MapFrom(m => MapAttribute(m, "number")))
				.ForMember(dest => dest.Supported, opt => opt.MapFrom(m => MapAttribute(m, "supported")))
				.ForMember(dest => dest.Protect, opt => opt.MapFrom(m => MapAttribute(m, "protect")))
				.ForMember(dest => dest.Author, opt => opt.MapFrom(m => MapAttribute(m, "author")))
				.ForMember(dest => dest.Contact, opt => opt.MapFrom(m => MapAttribute(m, "contact")))
				.ForMember(dest => dest.Enums, opt => opt.MapFrom(m => m.Descendants("enum")))
				.ForMember(dest => dest.Types, opt => opt.MapFrom(m => m.Descendants("type")))
				.ForMember(dest => dest.Commands, opt => opt.MapFrom(m => m.Descendants("command")))
				.ForMember(dest => dest.Usages, opt => opt.MapFrom(m => m.Descendants("usage")));
		}

		private void ConfigureVkExtensionEnums()
		{
			CreateMap<XElement, VkExtensionEnum>()
				.ForMember(dest => dest.Name, opt => opt.MapFrom(m => MapAttribute(m, "name")))
				.ForMember(dest => dest.Value, opt => opt.MapFrom(m => MapAttribute(m, "value")))
				.ForMember(dest => dest.Offset, opt => opt.MapFrom(m => MapAttribute(m, "offset")))
				.ForMember(dest => dest.Extends, opt => opt.MapFrom(m => MapAttribute(m, "extends")))
				.ForMember(dest => dest.BitPos, opt => opt.MapFrom(m => MapAttribute(m, "bitpos")))
				.ForMember(dest => dest.Comment, opt => opt.MapFrom(m => MapAttribute(m, "comment")))
				.ForMember(dest => dest.Dir, opt => opt.MapFrom(m => MapAttribute(m, "dir")));
		}

		private void ConfigureVkExtensionTypes()
		{
			CreateMap<XElement, VkExtensionType>()
				.ForMember(dest => dest.Name, opt => opt.MapFrom(m => MapAttribute(m, "name")));
		}

		private void ConfigureVkExtensionCommands()
		{
			CreateMap<XElement, VkExtensionCommand>()
				.ForMember(dest => dest.Name, opt => opt.MapFrom(m => MapAttribute(m, "name")));
		}

		private void ConfigureVkExtensionUsages()
		{
			CreateMap<XElement, VkExtensionUsage>()
				.ForMember(dest => dest.Command, opt => opt.MapFrom(m => MapAttribute(m, "command")))
				.ForMember(dest => dest.Struct, opt => opt.MapFrom(m => MapAttribute(m, "struct")))
				.ForMember(dest => dest.Value, opt => opt.MapFrom(m => m.GetInnerXml()));
		}

		#endregion

		private void ConfigureVkUsage()
		{
			CreateMap<XElement, VkUsage>()
				.ForMember(dest => dest.Comment, opt => opt.MapFrom(m => m.Value));
		}

		#region Feature Mapping

		private void ConfigureVkFeature()
		{
			CreateMap<XElement, VkFeature>()
				.ForMember(dest => dest.Api, opt => opt.MapFrom(m => m.Attribute("api").Value))
				.ForMember(dest => dest.Name, opt => opt.MapFrom(m => m.Attribute("name").Value))
				.ForMember(dest => dest.Number, opt => opt.MapFrom(m => m.Attribute("number").Value))
				.ForMember(dest => dest.Requires, opt => opt.MapFrom(m => m.Descendants("require")));
		}

		private void ConfigureVkFeatureRequires()
		{
			CreateMap<XElement, VkFeatureRequire>()
				.ForMember(dest => dest.Comment, opt => opt.MapFrom(m => MapAttribute(m, "comment")))
				.ForMember(dest => dest.Types, opt => opt.MapFrom(m => m.Descendants("type")))
				.ForMember(dest => dest.Enums, opt => opt.MapFrom(m => m.Descendants("enum")))
				.ForMember(dest => dest.Commands, opt => opt.MapFrom(m => m.Descendants("command")));
		}

		private void ConfigureVkFeatureRequireTypes()
		{
			CreateMap<XElement, VkFeatureRequireType>()
				.ForMember(dest => dest.Name, opt => opt.MapFrom(m => m.Value));
		}

		private void ConfigureVkFeatureRequireEnums()
		{
			CreateMap<XElement, VkFeatureRequireEnum>()
				.ForMember(dest => dest.Name, opt => opt.MapFrom(m => m.Value));
		}

		private void ConfigureVkFeatureRequireCommands()
		{
			CreateMap<XElement, VkFeatureRequireCommand>()
				.ForMember(dest => dest.Name, opt => opt.MapFrom(m => m.Value));
		}

		#endregion

		protected override void Configure()
		{
			ConfigureVkRegistry();
			ConfigureVkVendorId();
			ConfigureVkTag();
			ConfigureVkInclude();
			ConfigureVkTypeRequires();
			ConfigureVkTypeDefines();
			ConfigureVkTypeBaseType();
			ConfigureVkTypeBitmask();
			ConfigureVkTypeHandle();
			ConfigureVkTypeEnum();
			ConfigureVkTypeFuncPointer();
			ConfigureVkTypeFuncPointerParameter();
			ConfigureVkTypeStruct();
			ConfigureVkTypeStructMember();
			ConfigureVkTypeUnion();
			ConfigureVkTypeUnionMember();
			ConfigureVkUsage();

			ConfigureVkExtensions();
			ConfigureVkExtensionEnums();
			ConfigureVkExtensionTypes();
			ConfigureVkExtensionCommands();
			ConfigureVkExtensionUsages();

			ConfigureConstants();
			ConfigureConstantsValues();
			ConfigureEnum();
			ConfigureEnumValue();
			ConfigureCommand();
			ConfigureCommandParameter();

			ConfigureVkFeature();
			ConfigureVkFeatureRequires();
			ConfigureVkFeatureRequireTypes();
			ConfigureVkFeatureRequireEnums();
			ConfigureVkFeatureRequireCommands();
		}

		#region Mapping Helpers

		private string MapFunctionPointerReturnType(XElement funcElement)
		{
			var funcParts = funcElement.FirstNode.ToString().Split(' ');

			return funcParts[7].Replace("*", "");
		}

		private IList<XElement> GetTypesByCategory(XElement root, string category)
		{
			var elements = root.Descendants("type").Where(x => x.Attribute("category")?.Value == category);

			return elements.ToList();
		}

		private IList<XElement> GetTypesByAttribute(XElement root, string attributeName)
		{
			var elements = root.Descendants("type").Where(x => x.Attribute(attributeName) != null);

			return elements.ToList();
		}

		private string MapAttribute(XElement typeElement, string attributeName)
		{
			var attributeValue = typeElement.Attribute(attributeName)?.Value;

			return attributeValue;
		}

		private string MapElement(XElement typeElement, string elementName)
		{
			var attributeValue = typeElement.Element(elementName)?.Value;

			return attributeValue;
		}

		private string MapTypeName(XElement typeElement)
		{
			string name = null;

			var attributeName = typeElement.Attribute("name")?.Value;

			if (string.IsNullOrEmpty(attributeName))
			{
				name = typeElement.FirstNode.NextNode.GetInnerXml();
			}
			else
			{
				name = attributeName;
			}

			return name;
		}

		private string MapBaseTypeName(XElement typeElement)
		{
			var name = typeElement.FirstNode.NextNode.NextNode.GetInnerXml();

			return name;
		}

		private string MapBaseTypeType(XElement typeElement)
		{
			var name = typeElement.FirstNode.NextNode.GetInnerXml();

			return name;
		}

		#endregion
	}
}
