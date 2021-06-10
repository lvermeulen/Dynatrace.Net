using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Common.Extensions;
using Dynatrace.Net.Common.Models;
using Dynatrace.Net.Configuration.CalculatedMetrics.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private IFlurlRequest GetCalculatedMetricsLogMonitoringUrl()
		{
			return GetBaseUrl()
				.AppendPathSegment("config/v1/calculatedMetrics/log");
		}

		public async Task<StubList> GetCalculatedLogMonitoringMetricsAsync(CancellationToken cancellationToken = default)
		{
			var response = await GetCalculatedMetricsLogMonitoringUrl()
				.GetJsonIfNotEmptyAsync(new StubList(), cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<LogMetricConfig> GetCalculatedLogMonitoringMetricAsync(string metricKey, CancellationToken cancellationToken = default)
		{
			var response = await GetCalculatedMetricsLogMonitoringUrl()
				.AppendPathSegment(metricKey)
				.GetJsonWithErrorCheckingAsync<LogMetricConfig>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<bool> UpdateCalculatedLogMonitoringMetricAsync(string metricKey, LogMetricConfig body, CancellationToken cancellationToken = default)
		{
			var response = await GetCalculatedMetricsLogMonitoringUrl()
				.AppendPathSegment(metricKey)
				.PutJsonAsync(body, cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}

		public async Task<bool> DeleteCalculatedLogMonitoringMetricAsync(string metricKey, CancellationToken cancellationToken = default)
		{
			var response = await GetCalculatedMetricsLogMonitoringUrl()
				.AppendPathSegment(metricKey)
				.DeleteAsync(cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}
	}
}
