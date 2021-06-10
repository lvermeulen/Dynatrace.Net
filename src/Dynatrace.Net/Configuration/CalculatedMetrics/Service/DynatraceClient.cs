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
		private IFlurlRequest GetCalculatedMetricsServiceUrl()
		{
			return GetBaseUrl()
				.AppendPathSegment("config/v1/calculatedMetrics/service");
		}

		public async Task<StubList> GetCalculatedServiceMetricsAsync(CancellationToken cancellationToken = default)
		{
			var response = await GetCalculatedMetricsServiceUrl()
				.GetJsonWithErrorCheckingAsync<StubList>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<CalculatedServiceMetric> GetCalculatedServiceMetricAsync(string metricKey, CancellationToken cancellationToken = default)
		{
			var response = await GetCalculatedMetricsServiceUrl()
				.AppendPathSegment(metricKey)
				.GetJsonWithErrorCheckingAsync<CalculatedServiceMetric>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<CalculatedServiceMetric> AddCalculatedServiceMetricAsync(CalculatedServiceMetric body, CancellationToken cancellationToken = default)
		{
			var response = await GetCalculatedMetricsServiceUrl()
				.PostJsonAsync(body, cancellationToken)
				.ReceiveJsonWithErrorChecking<CalculatedServiceMetric>()
				.ConfigureAwait(false);

			return response;
		}

		public async Task<bool> UpdateCalculatedServiceMetricAsync(string metricKey, CalculatedServiceMetric body, CancellationToken cancellationToken = default)
		{
			var response = await GetCalculatedMetricsServiceUrl()
				.AppendPathSegment(metricKey)
				.PutJsonAsync(body, cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}

		public async Task<bool> DeleteCalculatedServiceMetricAsync(string metricKey, CancellationToken cancellationToken = default)
		{
			var response = await GetCalculatedMetricsServiceUrl()
				.AppendPathSegment(metricKey)
				.DeleteAsync(cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}
	}
}
