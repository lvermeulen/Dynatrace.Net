using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Configuration.AnomalyDetection.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private IFlurlRequest GetAnomalyDetectionServicesUrl()
		{
			return GetBaseUrl()
				.AppendPathSegment("config/v1/anomalyDetection/services");
		}

		public async Task<ServiceAnomalyDetectionConfig> GetAnomalyDetectionServicesConfigurationAsync(CancellationToken cancellationToken = default)
		{
			var response = await GetAnomalyDetectionServicesUrl()
				.GetJsonAsync<ServiceAnomalyDetectionConfig>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<bool> UpdateAnomalyDetectionServicesConfigurationAsync(ServiceAnomalyDetectionConfig body, CancellationToken cancellationToken = default)
		{
			var response = await GetAnomalyDetectionServicesUrl()
				.PutJsonAsync(body, cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}
	}
}
