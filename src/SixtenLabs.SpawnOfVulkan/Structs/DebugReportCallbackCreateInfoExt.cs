using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct DebugReportCallbackCreateInfoExt
    {
        internal StructureType SType;
        internal IntPtr PNext;
        internal DebugReportFlagsExt Flags;
        internal IntPtr PfnCallback;
        internal IntPtr PUserData;
    }
}