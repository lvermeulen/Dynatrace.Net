using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Common.Extensions;
using Dynatrace.Net.Environment.LogMonitoring.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private IFlurlRequest GetLogMonitoringCustomDevicesUrl(string customDeviceId)
		{
			return GetBaseUrl()
				.AppendPathSegment($"v1/entity/infrastructure/custom-devices/{customDeviceId}/logs");
		}

		public async Task<LogListForCustomDeviceResult> GetCustomDeviceLogsAsync(string customDeviceId, CancellationToken cancellationToken = default)
		{
			var response = await GetLogMonitoringCustomDevicesUrl(customDeviceId)
				.GetJsonWithErrorCheckingAsync<LogListForCustomDeviceResult>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<string> PostCustomDeviceLogAnalysisJobAsync(string customDeviceId, string logPath, string query = null, long? startTimestamp = null, long? endTimestamp = null, ExtractFields body = null,
			CancellationToken cancellationToken = default)
		{
			var queryParamValues = new Dictionary<string, object>
			{
				[nameof(query)] = query,
				[nameof(startTimestamp)] = startTimestamp,
				[nameof(endTimestamp)] = endTimestamp
			};

			string response = await GetLogMonitoringCustomDevicesUrl(customDeviceId)
				.AppendPathSegment(logPath)
				.SetQueryParams(queryParamValues)
				.PostJsonAsync(body, cancellationToken)
				.ReceiveString()
				.ConfigureAwait(false);

			return response;
		}

		public async Task<LogJobStatusResult> GetCustomDeviceLogAnalysisJobStatusAsync(string customDeviceId, string jobId, CancellationToken cancellationToken = default)
		{
			var response = await GetLogMonitoringCustomDevicesUrl(customDeviceId)
				.AppendPathSegment("jobs")
				.AppendPathSegment(jobId)
				.GetJsonWithErrorCheckingAsync<LogJobStatusResult>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<LogJobRecordsResult> GetCustomDeviceLogAnalysisJobContentAsync(string customDeviceId, string jobId, string scrollToken = null, int? pageSize = null,
			CancellationToken cancellationToken = default)
		{
			var queryParamValues = new Dictionary<string, object>
			{
				[nameof(scrollToken)] = scrollToken,
				[nameof(pageSize)] = pageSize
			};

			var response = await GetLogMonitoringCustomDevicesUrl(customDeviceId)
				.AppendPathSegment("jobs")
				.AppendPathSegment(jobId)
				.AppendPathSegment("records")
				.SetQueryParams(queryParamValues)
				.GetJsonWithErrorCheckingAsync<LogJobRecordsResult>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<LogJobRecordsResult> PostCustomDeviceLogFilteredContentAsync(string customDeviceId, string jobId, string scrollToken = null, int? pageSize = null, FilterLogContent body = null,
			CancellationToken cancellationToken = default)
		{
			var queryParamValues = new Dictionary<string, object>
			{
				[nameof(scrollToken)] = scrollToken,
				[nameof(pageSize)] = pageSize
			};

			var response = await GetLogMonitoringCustomDevicesUrl(customDeviceId)
				.AppendPathSegment("jobs")
				.AppendPathSegment(jobId)
				.AppendPathSegment("records")
				.SetQueryParams(queryParamValues)
				.PostJsonAsync(body, cancellationToken)
				.ReceiveJsonWithErrorChecking<LogJobRecordsResult>()
				.ConfigureAwait(false);

			return response;
		}

		public async Task<LogJobRecordsTopValuesRestResult> PostCustomDeviceLogTopContentAsync(string customDeviceId, string jobId, FilterTopLogRecords body = null,
			CancellationToken cancellationToken = default)
		{
			var response = await GetLogMonitoringCustomDevicesUrl(customDeviceId)
				.AppendPathSegment("jobs")
				.AppendPathSegment(jobId)
				.AppendPathSegment("records")
				.AppendPathSegment("top")
				.PostJsonAsync(body, cancellationToken)
				.ReceiveJsonWithErrorChecking<LogJobRecordsTopValuesRestResult>()
				.ConfigureAwait(false);

			return response;
		}

		public async Task<string> DeleteCustomDeviceLogAnalysisJobAsync(string customDeviceId, string jobId, CancellationToken cancellationToken = default)
		{
			string response = await GetLogMonitoringCustomDevicesUrl(customDeviceId)
				.AppendPathSegment("jobs")
				.AppendPathSegment(jobId)
				.DeleteAsync(cancellationToken)
				.ReceiveString()
				.ConfigureAwait(false);

			return response;
		}
	}
}
