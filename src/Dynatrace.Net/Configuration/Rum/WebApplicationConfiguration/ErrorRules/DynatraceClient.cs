using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Common.Extensions;
using Dynatrace.Net.Configuration.Rum.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private IFlurlRequest GetErrorRulesUrl(string id)
		{
			return GetBaseUrl()
				.AppendPathSegment($"config/v1/applications/web/{id}/errorRules");
		}

		public async Task<ApplicationErrorRules> GetErrorRulesAsync(string id, CancellationToken cancellationToken = default)
		{
			var result = await GetErrorRulesUrl(id)
				.GetJsonWithErrorCheckingAsync<ApplicationErrorRules>(cancellationToken)
				.ConfigureAwait(false);

			return result;
		}

		public async Task<bool> UpdateErrorRulesAsync(string id, ApplicationErrorRules body = null, CancellationToken cancellationToken = default)
		{
			var response = await GetErrorRulesUrl(id)
				.PutJsonAsync(body, cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}
	}
}
