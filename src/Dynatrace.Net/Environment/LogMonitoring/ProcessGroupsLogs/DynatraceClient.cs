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
		private IFlurlRequest GetLogMonitoringProcessGroupsUrl(string pgId)
		{
			return GetBaseUrl()
				.AppendPathSegment($"v1/entity/infrastructure/process-groups/{pgId}/logs");
		}

		public async Task<LogList4PgResult> GetProcessGroupLogsAsync(string pgId, CancellationToken cancellationToken = default)
		{
			var response = await GetLogMonitoringProcessGroupsUrl(pgId)
				.GetJsonWithErrorCheckingAsync<LogList4PgResult>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<string> PostProcessGroupsLogAnalysisJobAsync(string pgId, string logPath, IEnumerable<string> hostFilter = null, string query = null, long? startTimestamp = null, long? endTimestamp = null,
			ExtractFields body = null, CancellationToken cancellationToken = default)
		{
			var queryParamValues = new Dictionary<string, object>
			{
				[nameof(hostFilter)] = hostFilter == null ? null : string.Join(",", hostFilter),
				[nameof(query)] = query,
				[nameof(startTimestamp)] = startTimestamp,
				[nameof(endTimestamp)] = endTimestamp
			};

			string response = await GetLogMonitoringProcessGroupsUrl(pgId)
				.AppendPathSegment(logPath)
				.SetQueryParams(queryParamValues)
				.PostJsonAsync(body, cancellationToken)
				.ReceiveString()
				.ConfigureAwait(false);

			return response;
		}

		public async Task<LogJobStatusResult> GetProcessGroupLogAnalysisJobStatusAsync(string pgId, string jobId, CancellationToken cancellationToken = default)
		{
			var response = await GetLogMonitoringProcessGroupsUrl(pgId)
				.AppendPathSegment("jobs")
				.AppendPathSegment(jobId)
				.GetJsonWithErrorCheckingAsync<LogJobStatusResult>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<LogJobRecordsResult> GetProcessGroupLogAnalysisJobContentAsync(string pgId, string jobId, string scrollToken = null, int? pageSize = null,
			CancellationToken cancellationToken = default)
		{
			var queryParamValues = new Dictionary<string, object>
			{
				[nameof(scrollToken)] = scrollToken,
				[nameof(pageSize)] = pageSize
			};

			var response = await GetLogMonitoringProcessGroupsUrl(pgId)
				.AppendPathSegment("jobs")
				.AppendPathSegment(jobId)
				.AppendPathSegment("records")
				.SetQueryParams(queryParamValues)
				.GetJsonWithErrorCheckingAsync<LogJobRecordsResult>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<LogJobRecordsResult> PostProcessGroupLogFilteredContentAsync(string pgId, string jobId, string scrollToken = null, int? pageSize = null, FilterLogContent body = null,
			CancellationToken cancellationToken = default)
		{
			var queryParamValues = new Dictionary<string, object>
			{
				[nameof(scrollToken)] = scrollToken,
				[nameof(pageSize)] = pageSize
			};

			var response = await GetLogMonitoringProcessGroupsUrl(pgId)
				.AppendPathSegment("jobs")
				.AppendPathSegment(jobId)
				.AppendPathSegment("records")
				.SetQueryParams(queryParamValues)
				.PostJsonAsync(body, cancellationToken)
				.ReceiveJsonWithErrorChecking<LogJobRecordsResult>()
				.ConfigureAwait(false);

			return response;
		}

		public async Task<LogJobRecordsTopValuesRestResult> PostProcessGroupLogTopContentAsync(string pgId, string jobId, FilterTopLogRecords body = null,
			CancellationToken cancellationToken = default)
		{
			var response = await GetLogMonitoringProcessGroupsUrl(pgId)
				.AppendPathSegment("jobs")
				.AppendPathSegment(jobId)
				.AppendPathSegment("records")
				.AppendPathSegment("top")
				.PostJsonAsync(body, cancellationToken)
				.ReceiveJsonWithErrorChecking<LogJobRecordsTopValuesRestResult>()
				.ConfigureAwait(false);

			return response;
		}

		public async Task<string> DeleteProcessGroupLogAnalysisJobAsync(string pgId, string jobId, CancellationToken cancellationToken = default)
		{
			string response = await GetLogMonitoringProcessGroupsUrl(pgId)
				.AppendPathSegment("jobs")
				.AppendPathSegment(jobId)
				.DeleteAsync(cancellationToken)
				.ReceiveString()
				.ConfigureAwait(false);

			return response;
		}
	}
}
