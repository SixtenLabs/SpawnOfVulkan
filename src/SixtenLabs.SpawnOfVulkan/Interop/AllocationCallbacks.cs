using System;

namespace SixtenLabs.SpawnOfVulkan
{
    unsafe public struct AllocationCallbacks
    {
        internal IntPtr pUserData;
        internal IntPtr pfnAllocation;
        internal IntPtr pfnReallocation;
        internal IntPtr pfnFree;
        internal IntPtr pfnInternalAllocation;
        internal IntPtr pfnInternalFree;
    }
}