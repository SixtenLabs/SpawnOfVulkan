using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct AllocationCallbacks
    {
        internal IntPtr PUserData;
        internal IntPtr PfnAllocation;
        internal IntPtr PfnReallocation;
        internal IntPtr PfnFree;
        internal IntPtr PfnInternalAllocation;
        internal IntPtr PfnInternalFree;
    }
}