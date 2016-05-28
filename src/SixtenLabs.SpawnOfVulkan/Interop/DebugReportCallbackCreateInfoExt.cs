using System;

namespace SixtenLabs.SpawnOfVulkan
{
    unsafe public struct DebugReportCallbackCreateInfoExt
    {
        internal StructureType sType;
        internal IntPtr pNext;
        internal DebugReportFlagsExt flags;
        internal IntPtr pfnCallback;
        internal IntPtr pUserData;
    }
}