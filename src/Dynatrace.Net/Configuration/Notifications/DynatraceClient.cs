using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Configuration.Notifications.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private IFlurlRequest GetNotificationsUrl()
		{
			return GetBaseUrl()
				.AppendPathSegment("config/v1/notifications");
		}

		public async Task<NotificationConfigStubListDto> GetAllNotificationConfigurationsAsync(CancellationToken cancellationToken = default)
		{
			var response = await GetNotificationsUrl()
				.GetJsonAsync<NotificationConfigStubListDto>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<NotificationConfig> GetNotificationConfigurationAsync(string id, CancellationToken cancellationToken = default)
		{
			var response = await GetNotificationsUrl()
				.AppendPathSegment(id)
				.GetJsonAsync<NotificationConfig>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<bool> CreateNotificationConfigurationAsync(NotificationConfig body, CancellationToken cancellationToken = default)
		{
			var response = await GetNotificationsUrl()
				.PostJsonAsync(body, cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}

		public async Task<bool> UpdateNotificationConfigurationAsync(string id, NotificationConfig body, CancellationToken cancellationToken = default)
		{
			var response = await GetNotificationsUrl()
				.AppendPathSegment(id)
				.PutJsonAsync(body, cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}

		public async Task<bool> DeleteNotificationConfigurationAsync(string id, CancellationToken cancellationToken = default)
		{
			var response = await GetNotificationsUrl()
				.AppendPathSegment(id)
				.DeleteAsync(cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}
	}
}
