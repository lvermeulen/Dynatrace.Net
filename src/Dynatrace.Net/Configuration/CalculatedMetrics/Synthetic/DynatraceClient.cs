using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Common.Models;
using Dynatrace.Net.Configuration.CalculatedMetrics.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private IFlurlRequest GetCalculatedMetricsSyntheticUrl()
		{
			return GetBaseUrl()
				.AppendPathSegment("config/v1/calculatedMetrics/synthetic");
		}

		public async Task<StubList> GetCalculatedSyntheticMetricsAsync(CancellationToken cancellationToken = default)
		{
			var response = await GetCalculatedMetricsSyntheticUrl()
				.GetJsonAsync<StubList>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<CalculatedSyntheticMetric> GetCalculatedSyntheticMetricAsync(string metricKey, CancellationToken cancellationToken = default)
		{
			var response = await GetCalculatedMetricsSyntheticUrl()
				.AppendPathSegment(metricKey)
				.GetJsonAsync<CalculatedSyntheticMetric>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<CalculatedSyntheticMetric> AddCalculatedSyntheticMetricAsync(CalculatedSyntheticMetric body, CancellationToken cancellationToken = default)
		{
			var response = await GetCalculatedMetricsSyntheticUrl()
				.PostJsonAsync(body, cancellationToken)
				.ReceiveJson<CalculatedSyntheticMetric>()
				.ConfigureAwait(false);

			return response;
		}

		public async Task<bool> UpdateCalculatedSyntheticMetricAsync(string metricKey, SyntheticMetricUpdate body, CancellationToken cancellationToken = default)
		{
			var response = await GetCalculatedMetricsSyntheticUrl()
				.AppendPathSegment(metricKey)
				.PutJsonAsync(body, cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}

		public async Task<bool> DeleteCalculatedSyntheticMetricAsync(string metricKey, CancellationToken cancellationToken = default)
		{
			var response = await GetCalculatedMetricsSyntheticUrl()
				.AppendPathSegment(metricKey)
				.DeleteAsync(cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}
	}
}
