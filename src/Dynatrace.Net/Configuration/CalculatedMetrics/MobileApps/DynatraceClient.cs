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
		private IFlurlRequest GetCalculatedMetricsMobileAppsUrl()
		{
			return GetBaseUrl()
				.AppendPathSegment("config/v1/calculatedMetrics/mobile");
		}

		public async Task<StubList> GetCalculatedMobileAppsMetricsAsync(CancellationToken cancellationToken = default)
		{
			var response = await GetCalculatedMetricsMobileAppsUrl()
				.GetJsonAsync<StubList>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<CalculatedMobileMetric> GetCalculatedMobileAppsMetricAsync(string metricKey, CancellationToken cancellationToken = default)
		{
			var response = await GetCalculatedMetricsMobileAppsUrl()
				.AppendPathSegment(metricKey)
				.GetJsonAsync<CalculatedMobileMetric>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<CalculatedMobileMetric> AddCalculatedMobileAppsMetricAsync(CalculatedMobileMetric body, CancellationToken cancellationToken = default)
		{
			var response = await GetCalculatedMetricsMobileAppsUrl()
				.PostJsonAsync(body, cancellationToken)
				.ReceiveJson<CalculatedMobileMetric>()
				.ConfigureAwait(false);

			return response;
		}

		public async Task<bool> UpdateCalculatedMobileAppsMetricAsync(string metricKey, CalculatedMobileMetricUpdate body, CancellationToken cancellationToken = default)
		{
			var response = await GetCalculatedMetricsMobileAppsUrl()
				.AppendPathSegment(metricKey)
				.PutJsonAsync(body, cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}

		public async Task<bool> DeleteCalculatedMobileAppsMetricAsync(string metricKey, CancellationToken cancellationToken = default)
		{
			var response = await GetCalculatedMetricsMobileAppsUrl()
				.AppendPathSegment(metricKey)
				.DeleteAsync(cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}
	}
}
