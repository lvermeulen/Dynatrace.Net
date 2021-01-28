using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Common.Models;
using Dynatrace.Net.Configuration.AutoTags.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private IFlurlRequest GetAutoTagsUrl()
		{
			return GetBaseUrl()
				.AppendPathSegment("config/v1/autoTags");
		}

		public async Task<StubList> GetAutoTagsAsync(CancellationToken cancellationToken = default)
		{
			var response = await GetAutoTagsUrl()
				.GetJsonAsync<StubList>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<AutoTag> GetAutoTagAsync(string id, bool? includeProcessGroupReferences = false, CancellationToken cancellationToken = default)
		{
			var response = await GetAutoTagsUrl()
				.AppendPathSegment(id)
				.SetQueryParam(nameof(includeProcessGroupReferences), includeProcessGroupReferences)
				.GetJsonAsync<AutoTag>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<EntityShortRepresentation> CreateAutoTagAsync(AutoTag body, CancellationToken cancellationToken = default)
		{
			var response = await GetAutoTagsUrl()
				.PostJsonAsync(body, cancellationToken)
				.ReceiveJson<EntityShortRepresentation>()
				.ConfigureAwait(false);

			return response;
		}

		public async Task<bool> UpdateAutoTagAsync(string id, AutoTag body, CancellationToken cancellationToken = default)
		{
			var response = await GetAutoTagsUrl()
				.AppendPathSegment(id)
				.PutJsonAsync(body, cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}

		public async Task<bool> DeleteAutoTagAsync(string id, CancellationToken cancellationToken = default)
		{
			var response = await GetAutoTagsUrl()
				.AppendPathSegment(id)
				.DeleteAsync(cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}
	}
}
