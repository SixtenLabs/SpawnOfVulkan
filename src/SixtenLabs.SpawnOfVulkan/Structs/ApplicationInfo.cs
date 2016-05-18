using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct ApplicationInfo
    {
        internal StructureType sType;
        internal IntPtr pNext;
        internal char pApplicationName;
        internal uint applicationVersion;
        internal char pEngineName;
        internal uint engineVersion;
        internal uint apiVersion;
    }
}