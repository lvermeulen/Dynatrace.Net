using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Common.Extensions;
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

		public async Task<StubList> GetAnomalyDetectionMetricEventRulesAsync(CancellationToken cancellationToken = default)
		{
			var response = await GetAnomalyDetectionMetricEventsUrl()
				.GetJsonWithErrorCheckingAsync<StubList>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<MetricEvent> GetAnomalyDetectionMetricEventRuleAsync(string id, CancellationToken cancellationToken = default)
		{
			var response = await GetAnomalyDetectionMetricEventsUrl()
				.AppendPathSegment(id)
				.GetJsonWithErrorCheckingAsync<MetricEvent>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<EntityShortRepresentation> AddAnomalyDetectionMetricEventRuleAsync(MetricEvent body, CancellationToken cancellationToken = default)
		{
			var response = await GetAnomalyDetectionMetricEventsUrl()
				.PostJsonAsync(body, cancellationToken)
				.ReceiveJsonWithErrorChecking<EntityShortRepresentation>()
				.ConfigureAwait(false);

			return response;
		}

		public async Task<bool> UpdateAnomalyDetectionMetricEventRuleAsync(string id, MetricEvent body, CancellationToken cancellationToken = default)
		{
			var response = await GetAnomalyDetectionMetricEventsUrl()
				.AppendPathSegment(id)
				.PutJsonAsync(body, cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}

		public async Task<bool> DeleteAnomalyDetectionMetricEventRuleAsync(string id, CancellationToken cancellationToken = default)
		{
			var response = await GetAnomalyDetectionMetricEventsUrl()
				.AppendPathSegment(id)
				.DeleteAsync(cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}
	}
}
