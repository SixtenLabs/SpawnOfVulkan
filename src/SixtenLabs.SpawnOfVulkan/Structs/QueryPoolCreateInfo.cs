using System;

namespace SixtenLabs.SpawnOfVulkan
{
    public struct QueryPoolCreateInfo
    {
        internal StructureType SType;
        internal IntPtr PNext;
        internal QueryPoolCreateFlags Flags;
        internal QueryType QueryType;
        internal uint QueryCount;
        internal QueryPipelineStatisticFlags PipelineStatistics;
    }
}