using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Configuration.AnomalyDetection.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private IFlurlRequest GetAnomalyDetectionProcessGroupsUrl(string id)
		{
			return GetBaseUrl()
				.AppendPathSegment($"config/v1/anomalyDetection/processGroups/{id}");
		}

		public async Task<AnomalyDetectionPg> GetAnomalyDetectionProcessGroupsConfigurationAsync(string id, CancellationToken cancellationToken = default)
		{
			var response = await GetAnomalyDetectionProcessGroupsUrl(id)
				.GetJsonAsync<AnomalyDetectionPg>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<bool> UpdateAnomalyDetectionProcessGroupsConfigurationAsync(string id, AnomalyDetectionPg body, CancellationToken cancellationToken = default)
		{
			var response = await GetAnomalyDetectionProcessGroupsUrl(id)
				.PutJsonAsync(body, cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}

		public async Task<bool> DeleteAnomalyDetectionProcessGroupsConfigurationAsync(string id, CancellationToken cancellationToken = default)
		{
			var response = await GetAnomalyDetectionProcessGroupsUrl(id)
				.DeleteAsync(cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}
	}
}
