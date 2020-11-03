using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Common.Models;
using Dynatrace.Net.Configuration.AnomalyDetection.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private IFlurlRequest GetAnomalyDetectionMetricEventsUrl()
		{
			return GetBaseUrl()
				.AppendPathSegment("config/v1/anomalyDetection/metricEvents");
		}

		public async Task<StubList> GetAnomalyDetectionMetricEventsAsync(CancellationToken cancellationToken = default)
		{
			var response = await GetAnomalyDetectionMetricEventsUrl()
				.GetJsonAsync<StubList>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<MetricEvent> GetAnomalyDetectionMetricEventAsync(string id, CancellationToken cancellationToken = default)
		{
			var response = await GetAnomalyDetectionMetricEventsUrl()
				.AppendPathSegment(id)
				.GetJsonAsync<MetricEvent>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<EntityShortRepresentation> AddAnomalyDetectionMetricEventRuleAsync(MetricEvent body, CancellationToken cancellationToken = default)
		{
			var response = await GetAnomalyDetectionMetricEventsUrl()
				.PostJsonAsync(body, cancellationToken)
				.ReceiveJson<EntityShortRepresentation>()
				.ConfigureAwait(false);

			return response;
		}

		public async Task<bool> UpdateAnomalyDetectionMetricEventsAsync(string id, MetricEvent body, CancellationToken cancellationToken = default)
		{
			var response = await GetAnomalyDetectionMetricEventsUrl()
				.AppendPathSegment(id)
				.PutJsonAsync(body, cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}

		public async Task<bool> DeleteAnomalyDetectionMetricEventsAsync(string id, CancellationToken cancellationToken = default)
		{
			var response = await GetAnomalyDetectionMetricEventsUrl()
				.AppendPathSegment(id)
				.DeleteAsync(cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}
	}
}
