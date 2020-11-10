using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Common.Models;
using Dynatrace.Net.Configuration.Services.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private IFlurlRequest GetRequestAttributeRulesUrl()
		{
			return GetBaseUrl()
				.AppendPathSegment("config/v1/service/requestAttributes");
		}

		public async Task<StubList> GetAllRequestAttributeRulesAsync(CancellationToken cancellationToken = default)
		{
			var response = await GetRequestAttributeRulesUrl()
				.GetJsonAsync<StubList>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<RequestAttribute> GetRequestAttributeRuleAsync(string id, CancellationToken cancellationToken = default)
		{
			var response = await GetRequestAttributeRulesUrl()
				.AppendPathSegment(id)
				.GetJsonAsync<RequestAttribute>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<EntityShortRepresentation> CreateRequestAttributeRuleAsync(RequestAttribute body = null, CancellationToken cancellationToken = default)
		{
			var response = await GetRequestAttributeRulesUrl()
				.PostJsonAsync(body, cancellationToken)
				.ReceiveJson<EntityShortRepresentation>()
				.ConfigureAwait(false);

			return response;
		}

		public async Task<bool> UpdateRequestAttributeRuleAsync(string id, RequestAttribute body = null, CancellationToken cancellationToken = default)
		{
			var response = await GetRequestAttributeRulesUrl()
				.AppendPathSegment(id)
				.PutJsonAsync(body, cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}

		public async Task<bool> DeleteRequestAttributeRuleAsync(string id, CancellationToken cancellationToken = default)
		{
			var response = await GetRequestAttributeRulesUrl()
				.AppendPathSegment(id)
				.DeleteAsync(cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}
	}
}
