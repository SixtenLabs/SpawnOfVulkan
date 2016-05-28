using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct ApplicationInfo
    {
        internal StructureType sType;
        internal IntPtr pNext;
        internal string pApplicationName;
        internal uint applicationVersion;
        internal string pEngineName;
        internal uint engineVersion;
        internal uint apiVersion;
    }
}