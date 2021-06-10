using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Common.Extensions;
using Dynatrace.Net.Common.Models;
using Dynatrace.Net.Configuration.Rum.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private IFlurlRequest GetKeyUserActionsUrl(string id)
		{
			return GetBaseUrl()
				.AppendPathSegment($"config/v1/applications/web/{id}/keyUserActions");
		}

		public async Task<KeyUserActionList> GetKeyUserActionsAsync(string id, CancellationToken cancellationToken = default)
		{
			var result = await GetKeyUserActionsUrl(id)
				.GetJsonWithErrorCheckingAsync<KeyUserActionList>(cancellationToken)
				.ConfigureAwait(false);

			return result;
		}

		public async Task<EntityShortRepresentation> CreateKeyUserActionAsync(string id, KeyUserAction body = null, CancellationToken cancellationToken = default)
		{
			var result = await GetKeyUserActionsUrl(id)
				.PostJsonAsync(body, cancellationToken)
				.ReceiveJsonWithErrorChecking<EntityShortRepresentation>()
				.ConfigureAwait(false);

			return result;
		}

		public async Task<bool> DeleteKeyUserActionAsync(string id, string keyUserActionId, CancellationToken cancellationToken = default)
		{
			var response = await GetWebApplicationConfigurationDataPrivacyUrl(id)
				.AppendPathSegment(keyUserActionId)
				.DeleteAsync(cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}
	}
}
