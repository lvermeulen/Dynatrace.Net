using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Common.Extensions;
using Dynatrace.Net.Common.Models;
using Dynatrace.Net.Configuration.AlertingProfiles.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private IFlurlRequest GetAlertingProfilesUrl()
		{
			return GetBaseUrl()
				.AppendPathSegment("config/v1/alertingProfiles");
		}

		public async Task<StubList> GetAlertingProfilesAsync(CancellationToken cancellationToken = default)
		{
			var response = await GetAlertingProfilesUrl()
				.GetJsonWithErrorCheckingAsync<StubList>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<AlertingProfile> GetAlertingProfileAsync(string alertingProfileId, CancellationToken cancellationToken = default)
		{
			var response = await GetAlertingProfilesUrl()
				.AppendPathSegment(alertingProfileId)
				.GetJsonWithErrorCheckingAsync<AlertingProfile>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<EntityShortRepresentation> CreateAlertingProfileAsync(AlertingProfile body, CancellationToken cancellationToken = default)
		{
			var response = await GetAlertingProfilesUrl()
				.PostJsonAsync(body, cancellationToken)
				.ReceiveJsonWithErrorChecking<EntityShortRepresentation>()
				.ConfigureAwait(false);

			return response;
		}

		public async Task<EntityShortRepresentation> UpdateAlertingProfileAsync(string alertingProfileId, AlertingProfile body, CancellationToken cancellationToken = default)
		{
			var response = await GetAlertingProfilesUrl()
				.AppendPathSegment(alertingProfileId)
				.PutJsonAsync(body, cancellationToken)
				.ReceiveJsonWithErrorChecking<EntityShortRepresentation>()
				.ConfigureAwait(false);

			return response;
		}

		public async Task<bool> DeleteAlertingProfileAsync(string alertingProfileId, CancellationToken cancellationToken = default)
		{
			var response = await GetAlertingProfilesUrl()
				.DeleteAsync(cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}
	}
}