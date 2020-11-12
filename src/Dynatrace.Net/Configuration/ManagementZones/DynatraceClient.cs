using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Common.Models;
using Dynatrace.Net.Configuration.ManagementZones.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private IFlurlRequest GetManagementZonesUrl()
		{
			return GetBaseUrl()
				.AppendPathSegment("config/v1/managementZones");
		}

		public async Task<StubList> GetAllManagementZonesAsync(CancellationToken cancellationToken = default)
		{
			var response = await GetManagementZonesUrl()
				.GetJsonAsync<StubList>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<ManagementZone> GetManagementZoneAsync(string id, CancellationToken cancellationToken = default)
		{
			var response = await GetManagementZonesUrl()
				.AppendPathSegment(id)
				.GetJsonAsync<ManagementZone>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<bool> CreateManagementZoneAsync(ManagementZone body, CancellationToken cancellationToken = default)
		{
			var response = await GetManagementZonesUrl()
				.PostJsonAsync(body, cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}

		public async Task<bool> UpdateManagementZoneAsync(string id, ManagementZone body, CancellationToken cancellationToken = default)
		{
			var response = await GetManagementZonesUrl()
				.AppendPathSegment(id)
				.PutJsonAsync(body, cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}

		public async Task<bool> DeleteManagementZoneAsync(string id, CancellationToken cancellationToken = default)
		{
			var response = await GetManagementZonesUrl()
				.AppendPathSegment(id)
				.DeleteAsync(cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}
	}
}
