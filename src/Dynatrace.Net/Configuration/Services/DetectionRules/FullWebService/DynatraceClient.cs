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
		private IFlurlRequest GetDetectionRulesFullWebServiceUrl()
		{
			return GetBaseUrl()
				.AppendPathSegment("config/v1/service/detectionRules/FULL_WEB_SERVICE");
		}

		public async Task<StubList> GetAllDetectionRulesFullWebServiceAsync(CancellationToken cancellationToken = default)
		{
			var response = await GetDetectionRulesFullWebServiceUrl()
				.GetJsonAsync<StubList>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<FullWebServiceRule> GetDetectionRuleFullWebServiceAsync(string id, CancellationToken cancellationToken = default)
		{
			var response = await GetDetectionRulesFullWebServiceUrl()
				.AppendPathSegment(id)
				.GetJsonAsync<FullWebServiceRule>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<EntityShortRepresentation> CreateDetectionRuleFullWebServiceAsync(Positions? position = null, FullWebServiceRule body = null, 
			CancellationToken cancellationToken = default)
		{
			var response = await GetDetectionRulesFullWebServiceUrl()
				.SetQueryParam(nameof(position), s_positionsConverter.ConvertToString(position))
				.PostJsonAsync(body, cancellationToken)
				.ReceiveJson<EntityShortRepresentation>()
				.ConfigureAwait(false);

			return response;
		}

		public async Task<bool> UpdateDetectionRuleFullWebServiceAsync(string id, FullWebServiceRule body = null, CancellationToken cancellationToken = default)
		{
			var response = await GetDetectionRulesFullWebServiceUrl()
				.AppendPathSegment(id)
				.PutJsonAsync(body, cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}

		public async Task<bool> DeleteDetectionRuleFullWebServiceAsync(string id, CancellationToken cancellationToken = default)
		{
			var response = await GetDetectionRulesFullWebServiceUrl()
				.AppendPathSegment(id)
				.DeleteAsync(cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}

		public async Task<bool> UpdateDetectionRulesFullWebServiceReorderRulesAsync(StubList body = null, CancellationToken cancellationToken = default)
		{
			var response = await GetDetectionRulesFullWebServiceUrl()
				.AppendPathSegment("order")
				.PutJsonAsync(body, cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}
	}
}
