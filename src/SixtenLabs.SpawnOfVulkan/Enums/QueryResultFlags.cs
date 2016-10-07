using System;

namespace SixtenLabs.SpawnOfVulkan
{
    [Flags()]
    public enum QueryResultFlags : int
    {
        /// <summary>
        /// Results of the queries are written to the destination buffer as 64-bit values
        /// </summary>
        QueryResult64Bit = 0x1,
        /// <summary>
        /// Results of the queries are waited on before proceeding with the result copy
        /// </summary>
        QueryResultWaitBit = 0x2,
        /// <summary>
        /// Besides the results of the query, the availability of the results is also written
        /// </summary>
        QueryResultWithAvailabilityBit = 0x4,
        /// <summary>
        /// Copy the partial results of the query even if the final results are not available
        /// </summary>
        QueryResultPartialBit = 0x8
    }
}