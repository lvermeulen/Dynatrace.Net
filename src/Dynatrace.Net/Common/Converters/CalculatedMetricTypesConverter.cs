using System.Collections.Generic;
using Dynatrace.Net.Configuration.CalculatedMetrics.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class CalculatedMetricTypesConverter : JsonEnumConverter<CalculatedMetricTypes>
	{
		private static readonly Dictionary<CalculatedMetricTypes, string> s_pairs = new Dictionary<CalculatedMetricTypes, string>
		{
			[CalculatedMetricTypes.CpuTime] = "CPU_TIME",
			[CalculatedMetricTypes.DatabaseChildCallCount] = "DATABASE_CHILD_CALL_COUNT",
			[CalculatedMetricTypes.DatabaseChildCallTime] = "DATABASE_CHILD_CALL_TIME",
			[CalculatedMetricTypes.DiskIoTime] = "DISK_IO_TIME",
			[CalculatedMetricTypes.ExceptionCount] = "EXCEPTION_COUNT",
			[CalculatedMetricTypes.FailedRequestCount] = "FAILED_REQUEST_COUNT",
			[CalculatedMetricTypes.FailedRequestCountClient] = "FAILED_REQUEST_COUNT_CLIENT",
			[CalculatedMetricTypes.FailureRate] = "FAILURE_RATE",
			[CalculatedMetricTypes.FailureRateClient] = "FAILURE_RATE_CLIENT",
			[CalculatedMetricTypes.Http4XxErrorCount] = "HTTP_4XX_ERROR_COUNT",
			[CalculatedMetricTypes.Http4XxErrorCountClient] = "HTTP_4XX_ERROR_COUNT_CLIENT",
			[CalculatedMetricTypes.Http5XxErrorCount] = "HTTP_5XX_ERROR_COUNT",
			[CalculatedMetricTypes.Http5XxErrorCountClient] = "HTTP_5XX_ERROR_COUNT_CLIENT",
			[CalculatedMetricTypes.IoTime] = "IO_TIME",
			[CalculatedMetricTypes.LockTime] = "LOCK_TIME",
			[CalculatedMetricTypes.NetworkIoTime] = "NETWORK_IO_TIME",
			[CalculatedMetricTypes.NonDatabaseChildCallCount] = "NON_DATABASE_CHILD_CALL_COUNT",
			[CalculatedMetricTypes.NonDatabaseChildCallTime] = "NON_DATABASE_CHILD_CALL_TIME",
			[CalculatedMetricTypes.ProcessingTime] = "PROCESSING_TIME",
			[CalculatedMetricTypes.RequestAttribute] = "REQUEST_ATTRIBUTE",
			[CalculatedMetricTypes.RequestCount] = "REQUEST_COUNT",
			[CalculatedMetricTypes.ResponseTime] = "RESPONSE_TIME",
			[CalculatedMetricTypes.ResponseTimeClient] = "RESPONSE_TIME_CLIENT",
			[CalculatedMetricTypes.SuccessfulRequestCount] = "SUCCESSFUL_REQUEST_COUNT",
			[CalculatedMetricTypes.SuccessfulRequestCountClient] = "SUCCESSFUL_REQUEST_COUNT_CLIENT",
			[CalculatedMetricTypes.WaitTime] = "WAIT_TIME"
		};
		
		protected override Dictionary<CalculatedMetricTypes, string> Pairs { get; } = s_pairs;

		protected override string EntityString { get; } = "metric type";
	}
}
