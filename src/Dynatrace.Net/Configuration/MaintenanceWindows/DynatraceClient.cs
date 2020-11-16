using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Common.Models;
using Dynatrace.Net.Configuration.MaintenanceWindows.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private IFlurlRequest GetMaintenanceWindowsUrl()
		{
			return GetBaseUrl()
				.AppendPathSegment("config/v1/maintenanceWindows");
		}

		public async Task<StubList> GetMaintenanceWindowsAsync(CancellationToken cancellationToken = default)
		{
			var response = await GetMaintenanceWindowsUrl()
				.GetJsonAsync<StubList>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<MaintenanceWindow> GetMaintenanceWindowAsync(string id, CancellationToken cancellationToken = default)
		{
			var response = await GetMaintenanceWindowsUrl()
				.AppendPathSegment(id)
				.GetJsonAsync<MaintenanceWindow>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<EntityShortRepresentation> AddMaintenanceWindowAsync(MaintenanceWindow body, CancellationToken cancellationToken = default)
		{
			var response = await GetMaintenanceWindowsUrl()
				.PostJsonAsync(body, cancellationToken)
				.ReceiveJson<EntityShortRepresentation>()
				.ConfigureAwait(false);

			return response;
		}

		public async Task<bool> UpdateMaintenanceWindowAsync(string id, MaintenanceWindow body, CancellationToken cancellationToken = default)
		{
			var response = await GetMaintenanceWindowsUrl()
				.AppendPathSegment(id)
				.PutJsonAsync(body, cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}

		public async Task<bool> DeleteMaintenanceWindowAsync(string id, CancellationToken cancellationToken = default)
		{
			var response = await GetMaintenanceWindowsUrl()
				.AppendPathSegment(id)
				.DeleteAsync(cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}
	}
}
