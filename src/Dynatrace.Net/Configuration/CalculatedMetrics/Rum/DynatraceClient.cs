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
		private IFlurlRequest GetCalculatedMetricsRumUrl()
		{
			return GetBaseUrl()
				.AppendPathSegment("config/v1/calculatedMetrics/rum");
		}

		public async Task<StubList> GetCalculatedRumMetricsAsync(CancellationToken cancellationToken = default)
		{
			var response = await GetCalculatedMetricsRumUrl()
				.GetJsonWithErrorCheckingAsync<StubList>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<RumMetric> GetCalculatedRumMetricAsync(string metricKey, CancellationToken cancellationToken = default)
		{
			var response = await GetCalculatedMetricsRumUrl()
				.AppendPathSegment(metricKey)
				.GetJsonWithErrorCheckingAsync<RumMetric>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<RumMetric> AddCalculatedRumMetricAsync(RumMetric body, CancellationToken cancellationToken = default)
		{
			var response = await GetCalculatedMetricsRumUrl()
				.PostJsonAsync(body, cancellationToken)
				.ReceiveJsonWithErrorChecking<RumMetric>()
				.ConfigureAwait(false);

			return response;
		}

		public async Task<bool> UpdateCalculatedRumMetricAsync(string metricKey, RumMetricUpdate body, CancellationToken cancellationToken = default)
		{
			var response = await GetCalculatedMetricsRumUrl()
				.AppendPathSegment(metricKey)
				.PutJsonAsync(body, cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}

		public async Task<bool> DeleteCalculatedRumMetricAsync(string metricKey, CancellationToken cancellationToken = default)
		{
			var response = await GetCalculatedMetricsRumUrl()
				.AppendPathSegment(metricKey)
				.DeleteAsync(cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}
	}
}
