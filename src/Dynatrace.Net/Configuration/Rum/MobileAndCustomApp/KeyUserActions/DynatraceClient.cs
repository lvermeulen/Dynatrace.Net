using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Configuration.Rum.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private IFlurlRequest GetMobileAndCustomAppKeyUserActionsUrl(string applicationId)
		{
			return GetBaseUrl()
				.AppendPathSegment($"config/v1/applications/mobile/{applicationId}/keyUserActions");
		}

		public async Task<KeyUserActionMobileList> GetMobileAndCustomAppKeyUserActionsAsync(string applicationId, CancellationToken cancellationToken = default)
		{
			var result = await GetMobileAndCustomAppKeyUserActionsUrl(applicationId)
				.GetJsonAsync<KeyUserActionMobileList>(cancellationToken)
				.ConfigureAwait(false);

			return result;
		}

		public async Task<KeyUserActionMobile> CreateMobileAndCustomAppAsync(string applicationId, string actionName, CancellationToken cancellationToken = default)
		{
			var result = await GetMobileAndCustomAppKeyUserActionsUrl(applicationId)
				.AppendPathSegment(actionName)
				.PostAsync(null, cancellationToken)
				.ReceiveJson<KeyUserActionMobile>()
				.ConfigureAwait(false);

			return result;
		}

		public async Task<bool> DeleteMobileAndCustomAppAsync(string applicationId, string actionName, CancellationToken cancellationToken = default)
		{
			var response = await GetMobileAndCustomAppKeyUserActionsUrl(applicationId)
				.AppendPathSegment(actionName)
				.DeleteAsync(cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}
	}
}
