using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Common.Models;
using Dynatrace.Net.Configuration.Rum.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private IFlurlRequest GetMobileAndCustomAppAppUrl()
		{
			return GetBaseUrl()
				.AppendPathSegment("config/v1/applications/mobile");
		}

		public async Task<StubList> GetAllMobileAndCustomAppsAsync(CancellationToken cancellationToken = default)
		{
			var result = await GetMobileAndCustomAppAppUrl()
				.GetJsonAsync<StubList>(cancellationToken)
				.ConfigureAwait(false);

			return result;
		}

		public async Task<MobileCustomAppConfig> GetMobileAndCustomAppAsync(string id, CancellationToken cancellationToken = default)
		{
			var result = await GetMobileAndCustomAppAppUrl()
				.AppendPathSegment(id)
				.GetJsonAsync<MobileCustomAppConfig>(cancellationToken)
				.ConfigureAwait(false);

			return result;
		}

		public async Task<EntityShortRepresentation> CreateMobileAndCustomAppAsync(MobileCustomAppConfig body = null, CancellationToken cancellationToken = default)
		{
			var result = await GetMobileAndCustomAppAppUrl()
				.PostJsonAsync(body, cancellationToken)
				.ReceiveJson<EntityShortRepresentation>()
				.ConfigureAwait(false);

			return result;
		}

		public async Task<bool> UpdateMobileAndCustomAppAsync(string id, MobileCustomAppConfig body = null, CancellationToken cancellationToken = default)
		{
			var response = await GetMobileAndCustomAppAppUrl()
				.AppendPathSegment(id)
				.PutJsonAsync(body, cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}

		public async Task<bool> DeleteMobileAndCustomAppAsync(string id, CancellationToken cancellationToken = default)
		{
			var response = await GetMobileAndCustomAppAppUrl()
				.AppendPathSegment(id)
				.DeleteAsync(cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}
	}
}
