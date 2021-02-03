using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Configuration.FrequentIssueDetection.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private IFlurlRequest GetFrequentIssueDetectionUrl()
		{
			return GetBaseUrl()
				.AppendPathSegment("config/v1/frequentIssueDetection");
		}

		public async Task<FrequentIssueDetectionConfig> GetFrequentIssueDetectionConfigurationAsync(CancellationToken cancellationToken = default)
		{
			var response = await GetFrequentIssueDetectionUrl()
				.GetJsonAsync<FrequentIssueDetectionConfig>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}
		public async Task<bool> UpdateFrequentIssueDetectionConfigurationAsync(string id, FrequentIssueDetectionConfig body, CancellationToken cancellationToken = default)
		{
			var response = await GetFrequentIssueDetectionUrl()
				.AppendPathSegment(id)
				.PutJsonAsync(body, cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}
	}
}
