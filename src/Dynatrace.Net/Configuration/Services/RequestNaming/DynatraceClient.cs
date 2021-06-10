using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Common.Extensions;
using Dynatrace.Net.Common.Models;
using Dynatrace.Net.Configuration.Services.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private IFlurlRequest GetRequestNamingRulesUrl()
		{
			return GetBaseUrl()
				.AppendPathSegment("config/v1/service/requestNaming");
		}

		public async Task<StubList> GetAllRequestNamingRulesAsync(CancellationToken cancellationToken = default)
		{
			var response = await GetRequestNamingRulesUrl()
				.GetJsonWithErrorCheckingAsync<StubList>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<RequestNaming> GetRequestNamingRuleAsync(string id, CancellationToken cancellationToken = default)
		{
			var response = await GetRequestNamingRulesUrl()
				.AppendPathSegment(id)
				.GetJsonWithErrorCheckingAsync<RequestNaming>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<EntityShortRepresentation> CreateRequestNamingAsync(RequestNaming body = null, CancellationToken cancellationToken = default)
		{
			var response = await GetRequestNamingRulesUrl()
				.PostJsonAsync(body, cancellationToken)
				.ReceiveJsonWithErrorChecking<EntityShortRepresentation>()
				.ConfigureAwait(false);

			return response;
		}

		public async Task<bool> UpdateRequestNamingAsync(string id, RequestNaming body = null, CancellationToken cancellationToken = default)
		{
			var response = await GetRequestNamingRulesUrl()
				.AppendPathSegment(id)
				.PutJsonAsync(body, cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}

		public async Task<bool> DeleteRequestNamingAsync(string id, CancellationToken cancellationToken = default)
		{
			var response = await GetRequestNamingRulesUrl()
				.AppendPathSegment(id)
				.DeleteAsync(cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}
	}
}
