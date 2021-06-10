using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Common.Extensions;
using Dynatrace.Net.Common.Models;
using Dynatrace.Net.Configuration.Dashboards.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private IFlurlRequest GetDashboardsUrl()
		{
			return GetBaseUrl()
				.AppendPathSegment("config/v1/dashboards");
		}

		public async Task<DashboardList> GetDashboardsAsync(CancellationToken cancellationToken = default)
		{
			var response = await GetDashboardsUrl()
				.GetJsonWithErrorCheckingAsync<DashboardList>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<Dashboard> GetDashboardAsync(string id, CancellationToken cancellationToken = default)
		{
			var response = await GetDashboardsUrl()
				.AppendPathSegment(id)
				.GetJsonWithErrorCheckingAsync<Dashboard>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<EntityShortRepresentation> AddDashboardAsync(Dashboard body, CancellationToken cancellationToken = default)
		{
			var response = await GetDashboardsUrl()
				.PostJsonAsync(body, cancellationToken)
				.ReceiveJsonWithErrorChecking<EntityShortRepresentation>()
				.ConfigureAwait(false);

			return response;
		}

		public async Task<bool> UpdateDashboardAsync(string id, Dashboard body, CancellationToken cancellationToken = default)
		{
			var response = await GetDashboardsUrl()
				.AppendPathSegment(id)
				.PutJsonAsync(body, cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}

		public async Task<bool> DeleteDashboardAsync(string id, CancellationToken cancellationToken = default)
		{
			var response = await GetDashboardsUrl()
				.AppendPathSegment(id)
				.DeleteAsync(cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}
	}
}
