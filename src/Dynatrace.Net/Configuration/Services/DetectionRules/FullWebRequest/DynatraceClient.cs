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
		private IFlurlRequest GetDetectionRulesFullWebRequestUrl()
		{
			return GetBaseUrl()
				.AppendPathSegment("config/v1/service/detectionRules/FULL_WEB_REQUEST");
		}

		public async Task<StubList> GetAllDetectionRulesFullWebRequestAsync(CancellationToken cancellationToken = default)
		{
			var response = await GetDetectionRulesFullWebRequestUrl()
				.GetJsonAsync<StubList>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<FullWebRequestRule> GetDetectionRuleFullWebRequestAsync(string id, CancellationToken cancellationToken = default)
		{
			var response = await GetDetectionRulesFullWebRequestUrl()
				.AppendPathSegment(id)
				.GetJsonAsync<FullWebRequestRule>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<EntityShortRepresentation> CreateDetectionRuleFullWebRequestAsync(Positions? position = null, FullWebRequestRule body = null, 
			CancellationToken cancellationToken = default)
		{
			var response = await GetDetectionRulesFullWebRequestUrl()
				.SetQueryParam(nameof(position), s_positionsConverter.ConvertToString(position))
				.PostJsonAsync(body, cancellationToken)
				.ReceiveJson<EntityShortRepresentation>()
				.ConfigureAwait(false);

			return response;
		}

		public async Task<bool> UpdateDetectionRuleFullWebRequestAsync(string id, FullWebRequestRule body = null, CancellationToken cancellationToken = default)
		{
			var response = await GetDetectionRulesFullWebRequestUrl()
				.AppendPathSegment(id)
				.PutJsonAsync(body, cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}

		public async Task<bool> DeleteDetectionRuleFullWebRequestAsync(string id, CancellationToken cancellationToken = default)
		{
			var response = await GetDetectionRulesFullWebRequestUrl()
				.AppendPathSegment(id)
				.DeleteAsync(cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}

		public async Task<bool> UpdateDetectionRulesFullWebRequestReorderRulesAsync(StubList body = null, CancellationToken cancellationToken = default)
		{
			var response = await GetDetectionRulesFullWebRequestUrl()
				.AppendPathSegment("order")
				.PutJsonAsync(body, cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}
	}
}
