using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Environment.LogMonitoring.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private IFlurlRequest GetLogMonitoringHostsUrl(string hostId)
		{
			return GetBaseUrl()
				.AppendPathSegment($"v1/entity/infrastructure/hosts/{hostId}/logs");
		}

		public async Task<LogList4HostResult> GetHostLogsAsync(string hostId, CancellationToken cancellationToken = default)
		{
			var response = await GetLogMonitoringHostsUrl(hostId)
				.GetJsonAsync<LogList4HostResult>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<string> PostHostLogAnalysisJobAsync(string hostId, string logPath, string query = null, int? startTimestamp = null, int? endTimestamp = null, ExtractFields body = null,
			CancellationToken cancellationToken = default)
		{
			var queryParamValues = new Dictionary<string, object>
			{
				[nameof(query)] = query,
				[nameof(startTimestamp)] = startTimestamp,
				[nameof(endTimestamp)] = endTimestamp
			};

			string response = await GetLogMonitoringHostsUrl(hostId)
				.AppendPathSegment(logPath)
				.SetQueryParams(queryParamValues)
				.PostJsonAsync(body, cancellationToken)
				.ReceiveString()
				.ConfigureAwait(false);

			return response;
		}

		public async Task<LogJobStatusResult> GetHostLogAnalysisJobStatusAsync(string hostId, string jobId, CancellationToken cancellationToken = default)
		{
			var response = await GetLogMonitoringHostsUrl(hostId)
				.AppendPathSegment("jobs")
				.AppendPathSegment(jobId)
				.GetJsonAsync<LogJobStatusResult>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<LogJobRecordsResult> GetHostLogAnalysisJobContentAsync(string hostId, string jobId, string scrollToken = null, int? pageSize = null,
			CancellationToken cancellationToken = default)
		{
			var queryParamValues = new Dictionary<string, object>
			{
				[nameof(scrollToken)] = scrollToken,
				[nameof(pageSize)] = pageSize
			};

			var response = await GetLogMonitoringHostsUrl(hostId)
				.AppendPathSegment("jobs")
				.AppendPathSegment(jobId)
				.AppendPathSegment("records")
				.SetQueryParams(queryParamValues)
				.GetJsonAsync<LogJobRecordsResult>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<LogJobRecordsResult> PostHostLogFilteredContentAsync(string hostId, string jobId, string scrollToken = null, int? pageSize = null, FilterLogContent body = null,
			CancellationToken cancellationToken = default)
		{
			var queryParamValues = new Dictionary<string, object>
			{
				[nameof(scrollToken)] = scrollToken,
				[nameof(pageSize)] = pageSize
			};

			var response = await GetLogMonitoringHostsUrl(hostId)
				.AppendPathSegment("jobs")
				.AppendPathSegment(jobId)
				.AppendPathSegment("records")
				.SetQueryParams(queryParamValues)
				.PostJsonAsync(body, cancellationToken)
				.ReceiveJson<LogJobRecordsResult>()
				.ConfigureAwait(false);

			return response;
		}

		public async Task<LogJobRecordsTopValuesRestResult> PostHostLogTopContentAsync(string hostId, string jobId, FilterTopLogRecords body = null,
			CancellationToken cancellationToken = default)
		{
			var response = await GetLogMonitoringHostsUrl(hostId)
				.AppendPathSegment("jobs")
				.AppendPathSegment(jobId)
				.AppendPathSegment("records")
				.AppendPathSegment("top")
				.PostJsonAsync(body, cancellationToken)
				.ReceiveJson<LogJobRecordsTopValuesRestResult>()
				.ConfigureAwait(false);

			return response;
		}

		public async Task<string> DeleteHostLogAnalysisJobAsync(string hostId, string jobId, CancellationToken cancellationToken = default)
		{
			string response = await GetLogMonitoringHostsUrl(hostId)
				.AppendPathSegment("jobs")
				.AppendPathSegment(jobId)
				.DeleteAsync(cancellationToken)
				.ReceiveString()
				.ConfigureAwait(false);

			return response;
		}
	}
}
