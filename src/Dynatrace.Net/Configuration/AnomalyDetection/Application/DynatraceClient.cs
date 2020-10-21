using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Environment.Tokens.Models;
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

		public async Task<TokenMetadata> GetAnomalyDetectionApplicationAsync(string id, CancellationToken cancellationToken = default)
		{
			var response = await GetAnomalyDetectionApplicationUrl()
				.AppendPathSegment(id)
				.GetJsonAsync<TokenMetadata>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<bool> UpdateAnomalyDetectionApplicationAsync(string id, UpdateToken body, CancellationToken cancellationToken = default)
		{
			var response = await GetAnomalyDetectionApplicationUrl()
				.AppendPathSegment(id)
				.PutJsonAsync(body, cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}
	}
}
