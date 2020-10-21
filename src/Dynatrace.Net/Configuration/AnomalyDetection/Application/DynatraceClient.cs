using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Configuration.AnomalyDetection.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private IFlurlRequest GetAnomalyDetectionApplicationUrl()
		{
			return GetBaseUrl()
				.AppendPathSegment("config/v1/anomalyDetection/applications");
		}

		public async Task<ApplicationAnomalyDetectionConfig> GetAnomalyDetectionApplicationAsync(CancellationToken cancellationToken = default)
		{
			var response = await GetAnomalyDetectionApplicationUrl()
				.GetJsonAsync<ApplicationAnomalyDetectionConfig>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<bool> UpdateAnomalyDetectionApplicationAsync(ApplicationAnomalyDetectionConfig body, CancellationToken cancellationToken = default)
		{
			var response = await GetAnomalyDetectionApplicationUrl()
				.PutJsonAsync(body, cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}
	}
}
