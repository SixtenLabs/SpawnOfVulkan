using System;

namespace SixtenLabs.SpawnOfVulkan
{
    [Flags()]
    public enum DebugReportFlagsExt : int
    {
        DebugReportInformationBitExt = 0x1,
        DebugReportWarningBitExt = 0x2,
        DebugReportPerformanceWarningBitExt = 0x4,
        DebugReportErrorBitExt = 0x8,
        DebugReportDebugBitExt = 0x10
    }
}