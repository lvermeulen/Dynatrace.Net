using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Common.Extensions;
using Dynatrace.Net.Configuration.Rum.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private IFlurlRequest GetMobileAndCustomAppUserActionsUrl(string applicationId)
		{
			return GetBaseUrl()
				.AppendPathSegment($"config/v1/applications/mobile/{applicationId}/userActionAndSessionProperties");
		}

		public async Task<MobileSessionUserActionPropertyList> GetMobileAndCustomAppUserActionsAsync(string applicationId, CancellationToken cancellationToken = default)
		{
			var result = await GetMobileAndCustomAppUserActionsUrl(applicationId)
				.GetJsonWithErrorCheckingAsync<MobileSessionUserActionPropertyList>(cancellationToken)
				.ConfigureAwait(false);

			return result;
		}

		public async Task<MobileSessionUserActionProperty> GetMobileAndCustomAppUserActionAsync(string applicationId, string key, CancellationToken cancellationToken = default)
		{
			var result = await GetMobileAndCustomAppUserActionsUrl(applicationId)
				.AppendPathSegment(key)
				.GetJsonWithErrorCheckingAsync<MobileSessionUserActionProperty>(cancellationToken)
				.ConfigureAwait(false);

			return result;
		}

		public async Task<MobileSessionUserActionPropertyShort> CreateMobileAndCustomAppUserActionAsync(string applicationId, MobileSessionUserActionProperty body, CancellationToken cancellationToken = default)
		{
			var result = await GetMobileAndCustomAppUserActionsUrl(applicationId)
				.PostJsonAsync(body, cancellationToken)
				.ReceiveJsonWithErrorChecking<MobileSessionUserActionPropertyShort>()
				.ConfigureAwait(false);

			return result;
		}

		public async Task<MobileSessionUserActionPropertyShort> UpdateMobileAndCustomAppUserActionAsync(string applicationId, string key, MobileSessionUserActionPropertyUpd body, CancellationToken cancellationToken = default)
		{
			var result = await GetMobileAndCustomAppUserActionsUrl(applicationId)
				.AppendPathSegment(key)
				.PutJsonAsync(body, cancellationToken)
				.ReceiveJsonWithErrorChecking<MobileSessionUserActionPropertyShort>()
				.ConfigureAwait(false);

			return result;
		}

		public async Task<bool> DeleteMobileAndCustomAppUserActionAsync(string applicationId, string key, CancellationToken cancellationToken = default)
		{
			var response = await GetMobileAndCustomAppUserActionsUrl(applicationId)
				.AppendPathSegment(key)
				.DeleteAsync(cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}
	}
}
