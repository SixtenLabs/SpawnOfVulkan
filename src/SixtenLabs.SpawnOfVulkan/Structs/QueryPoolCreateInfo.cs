using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct QueryPoolCreateInfo
    {
        internal StructureType sType;
        internal IntPtr pNext;
        internal uint flags;
        internal QueryType queryType;
        internal uint queryCount;
        internal QueryPipelineStatisticFlags pipelineStatistics;
    }
}