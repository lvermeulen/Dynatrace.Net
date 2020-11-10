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
		private IFlurlRequest GetDetectionRulesOpaqueWebRequestUrl()
		{
			return GetBaseUrl()
				.AppendPathSegment("config/v1/service/detectionRules/OPAQUE_AND_EXTERNAL_WEB_REQUEST");
		}

		public async Task<StubList> GetAllDetectionRulesOpaqueWebRequestAsync(CancellationToken cancellationToken = default)
		{
			var response = await GetDetectionRulesOpaqueWebRequestUrl()
				.GetJsonAsync<StubList>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<OpaqueAndExternalWebRequestRule> GetDetectionRuleOpaqueWebRequestAsync(string id, CancellationToken cancellationToken = default)
		{
			var response = await GetDetectionRulesOpaqueWebRequestUrl()
				.AppendPathSegment(id)
				.GetJsonAsync<OpaqueAndExternalWebRequestRule>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<EntityShortRepresentation> CreateDetectionRuleOpaqueWebRequestAsync(Positions? position = null, OpaqueAndExternalWebRequestRule body = null, 
			CancellationToken cancellationToken = default)
		{
			var response = await GetDetectionRulesOpaqueWebRequestUrl()
				.SetQueryParam(nameof(position), s_positionsConverter.ConvertToString(position))
				.PostJsonAsync(body, cancellationToken)
				.ReceiveJson<EntityShortRepresentation>()
				.ConfigureAwait(false);

			return response;
		}

		public async Task<bool> UpdateDetectionRuleOpaqueWebRequestAsync(string id, OpaqueAndExternalWebRequestRule body = null, CancellationToken cancellationToken = default)
		{
			var response = await GetDetectionRulesOpaqueWebRequestUrl()
				.AppendPathSegment(id)
				.PutJsonAsync(body, cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}

		public async Task<bool> DeleteDetectionRuleOpaqueWebRequestAsync(string id, CancellationToken cancellationToken = default)
		{
			var response = await GetDetectionRulesOpaqueWebRequestUrl()
				.AppendPathSegment(id)
				.DeleteAsync(cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}

		public async Task<bool> UpdateDetectionRulesOpaqueWebRequestReorderRulesAsync(StubList body = null, CancellationToken cancellationToken = default)
		{
			var response = await GetDetectionRulesOpaqueWebRequestUrl()
				.AppendPathSegment("order")
				.PutJsonAsync(body, cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}
	}
}
