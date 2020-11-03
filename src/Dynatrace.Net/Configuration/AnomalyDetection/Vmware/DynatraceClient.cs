using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Configuration.AnomalyDetection.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private IFlurlRequest GetAnomalyDetectionVmwareUrl()
		{
			return GetBaseUrl()
				.AppendPathSegment("config/v1/anomalyDetection/vmware");
		}

		public async Task<VmwareAnomalyDetectionConfig> GetAnomalyDetectionVmwareConfigurationAsync(CancellationToken cancellationToken = default)
		{
			var response = await GetAnomalyDetectionVmwareUrl()
				.GetJsonAsync<VmwareAnomalyDetectionConfig>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<bool> UpdateAnomalyDetectionVmwareConfigurationAsync(VmwareAnomalyDetectionConfig body, CancellationToken cancellationToken = default)
		{
			var response = await GetAnomalyDetectionVmwareUrl()
				.PutJsonAsync(body, cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}
	}
}
