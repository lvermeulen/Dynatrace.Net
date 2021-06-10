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
		private IFlurlRequest GetAnomalyDetectionDatabaseServicesUrl()
		{
			return GetBaseUrl()
				.AppendPathSegment("config/v1/anomalyDetection/databaseServices");
		}

		public async Task<DatabaseAnomalyDetectionConfig> GetAnomalyDetectionDatabaseServicesConfigurationAsync(CancellationToken cancellationToken = default)
		{
			var response = await GetAnomalyDetectionDatabaseServicesUrl()
				.GetJsonWithErrorCheckingAsync<DatabaseAnomalyDetectionConfig>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<bool> UpdateAnomalyDetectionDatabaseServicesConfigurationAsync(DatabaseAnomalyDetectionConfig body, CancellationToken cancellationToken = default)
		{
			var response = await GetAnomalyDetectionDatabaseServicesUrl()
				.PutJsonAsync(body, cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}
	}
}
