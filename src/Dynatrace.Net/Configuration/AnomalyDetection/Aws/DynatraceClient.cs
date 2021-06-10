using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Common.Extensions;
using Dynatrace.Net.Configuration.AnomalyDetection.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private IFlurlRequest GetAnomalyDetectionAwsUrl()
		{
			return GetBaseUrl()
				.AppendPathSegment("config/v1/anomalyDetection/aws");
		}

		public async Task<AwsAnomalyDetectionConfig> GetAnomalyDetectionAwsConfigurationAsync(CancellationToken cancellationToken = default)
		{
			var response = await GetAnomalyDetectionAwsUrl()
				.GetJsonWithErrorCheckingAsync<AwsAnomalyDetectionConfig>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<bool> UpdateAnomalyDetectionAwsConfigurationAsync(AwsAnomalyDetectionConfig body, CancellationToken cancellationToken = default)
		{
			var response = await GetAnomalyDetectionAwsUrl()
				.PutJsonAsync(body, cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}
	}
}
