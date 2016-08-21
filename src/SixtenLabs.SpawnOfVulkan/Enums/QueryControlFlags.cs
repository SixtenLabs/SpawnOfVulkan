using System;

namespace SixtenLabs.SpawnOfVulkan
{
    [Flags()]
    public enum QueryControlFlags : int
    {
        /// <summary>
                /// Require precise results to be collected by the query
                /// </summary>
        QueryControlPreciseBit = 0x1
    }
}