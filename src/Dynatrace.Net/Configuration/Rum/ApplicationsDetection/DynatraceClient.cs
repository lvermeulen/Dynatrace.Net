using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Common.Models;
using Dynatrace.Net.Configuration.Rum.Models;
using Dynatrace.Net.Configuration.Services.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private IFlurlRequest GetRumApplicationDetectionUrl()
		{
			return GetBaseUrl()
				.AppendPathSegment("config/v1/applicationDetectionRules");
		}

		public async Task<StubList> GetAllRumApplicationDetectionRulesAsync(CancellationToken cancellationToken = default)
		{
			var result = await GetRumApplicationDetectionUrl()
				.GetJsonAsync<StubList>(cancellationToken)
				.ConfigureAwait(false);

			return result;
		}

		public async Task<ApplicationDetectionRuleConfig> GetRumApplicationDetectionRuleAsync(string id, CancellationToken cancellationToken = default)
		{
			var result = await GetRumApplicationDetectionUrl()
				.AppendPathSegment(id)
				.GetJsonAsync<ApplicationDetectionRuleConfig>(cancellationToken)
				.ConfigureAwait(false);

			return result;
		}

		public async Task<EntityShortRepresentation> CreateRumApplicationDetectionRuleAsync(Positions? position = null, ApplicationDetectionRuleConfig body = null, CancellationToken cancellationToken = default)
		{
			var result = await GetRumApplicationDetectionUrl()
				.SetQueryParam(nameof(position), s_positionsConverter.ConvertToString(position))
				.PostJsonAsync(body, cancellationToken)
				.ReceiveJson<EntityShortRepresentation>()
				.ConfigureAwait(false);

			return result;
		}

		public async Task<EntityShortRepresentation> UpdateRumApplicationDetectionRuleAsync(string id, ApplicationDetectionRuleConfig body = null, CancellationToken cancellationToken = default)
		{
			var result = await GetRumApplicationDetectionUrl()
				.AppendPathSegment(id)
				.PutJsonAsync(body, cancellationToken)
				.ReceiveJson<EntityShortRepresentation>()
				.ConfigureAwait(false);

			return result;
		}

		public async Task<bool> DeleteRumApplicationDetectionRuleAsync(string id, CancellationToken cancellationToken = default)
		{
			var response = await GetRumApplicationDetectionUrl()
				.AppendPathSegment(id)
				.DeleteAsync(cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}

		public async Task<bool> UpdateRumApplicationDetectionReorderRulesAsync(StubList body = null, CancellationToken cancellationToken = default)
		{
			var response = await GetRumApplicationDetectionUrl()
				.AppendPathSegment("reorder")
				.PutJsonAsync(body, cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}

		public async Task<ApplicationDetectionRulesHostDetectionSettings> GetRumApplicationDetectionHostDetectionHeadersAsync(CancellationToken cancellationToken = default)
		{
			var result = await GetRumApplicationDetectionUrl()
				.AppendPathSegment("hostDetection")
				.GetJsonAsync<ApplicationDetectionRulesHostDetectionSettings>(cancellationToken)
				.ConfigureAwait(false);

			return result;
		}

		public async Task<bool> UpdateRumApplicationDetectionHostDetectionHeadersAsync(ApplicationDetectionRulesHostDetectionSettings body = null, CancellationToken cancellationToken = default)
		{
			var response = await GetRumApplicationDetectionUrl()
				.AppendPathSegment("hostDetection")
				.PutJsonAsync(body, cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}
	}
}
