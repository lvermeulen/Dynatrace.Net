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
		private IFlurlRequest GetAnomalyDetectionDiskEventsUrl()
		{
			return GetBaseUrl()
				.AppendPathSegment("config/v1/anomalyDetection/diskEvents");
		}

		public async Task<StubList> GetAnomalyDetectionDiskEventRulesAsync(CancellationToken cancellationToken = default)
		{
			var response = await GetAnomalyDetectionDiskEventsUrl()
				.GetJsonAsync<StubList>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<DiskEventAnomalyDetectionConfig> GetAnomalyDetectionDiskEventRuleAsync(string id, CancellationToken cancellationToken = default)
		{
			var response = await GetAnomalyDetectionDiskEventsUrl()
				.AppendPathSegment(id)
				.GetJsonAsync<DiskEventAnomalyDetectionConfig>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<EntityShortRepresentation> AddAnomalyDetectionDiskEventRuleAsync(DiskEventAnomalyDetectionConfig body, CancellationToken cancellationToken = default)
		{
			var response = await GetAnomalyDetectionDiskEventsUrl()
				.PostJsonAsync(body, cancellationToken)
				.ReceiveJson<EntityShortRepresentation>()
				.ConfigureAwait(false);

			return response;
		}

		public async Task<bool> UpdateAnomalyDetectionDiskEventRuleAsync(string id, DiskEventAnomalyDetectionConfig body, CancellationToken cancellationToken = default)
		{
			var response = await GetAnomalyDetectionDiskEventsUrl()
				.AppendPathSegment(id)
				.PutJsonAsync(body, cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}

		public async Task<bool> DeleteAnomalyDetectionDiskEventRuleAsync(string id, CancellationToken cancellationToken = default)
		{
			var response = await GetAnomalyDetectionDiskEventsUrl()
				.AppendPathSegment(id)
				.DeleteAsync(cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}
	}
}
