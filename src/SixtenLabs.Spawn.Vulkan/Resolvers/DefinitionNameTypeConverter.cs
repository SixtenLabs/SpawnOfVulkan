using AutoMapper;
using SixtenLabs.Spawn.CSharp;
using SixtenLabs.Spawn.Vulkan.Spec;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixtenLabs.Spawn.Vulkan
{
  public class DefinitionNameTypeConverter : ITypeConverter<string, DefinitionName>
  {
    public DefinitionNameTypeConverter(IDefinitionDictionary definitionDictionary)
    {
      DefinitionDictionary = definitionDictionary;
    }

    public DefinitionName Convert(string source, DefinitionName definitionName, ResolutionContext context)
    {
      definitionName = new DefinitionName();
      definitionName.Original = source;
      definitionName.Translated = DefinitionDictionary.GetTranslatedName(source);

      return definitionName;
    }

    private IDefinitionDictionary DefinitionDictionary { get; }
  }
}
