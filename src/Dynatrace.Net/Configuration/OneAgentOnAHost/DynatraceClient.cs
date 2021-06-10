using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Common.Extensions;
using Dynatrace.Net.Configuration.OneAgentOnAHost.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private IFlurlRequest GetOneAgentOnAHostConfigUrl(string id)
		{
			return GetBaseUrl()
				.AppendPathSegment($"config/v1/hosts/{id}");
		}

		public async Task<HostConfig> GetOneAgentOnAHostConfigAsync(string id, CancellationToken cancellationToken = default)
		{
			var response = await GetOneAgentOnAHostConfigUrl(id)
				.GetJsonWithErrorCheckingAsync<HostConfig>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<HostAutoUpdateConfig> GetOneAgentOnAHostAutoUpdateConfigAsync(string id, CancellationToken cancellationToken = default)
		{
			var response = await GetOneAgentOnAHostConfigUrl(id)
				.GetJsonWithErrorCheckingAsync<HostAutoUpdateConfig>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<bool> UpdateOneAgentOnAHostAutoUpdateConfigAsync(string id, HostAutoUpdateConfig body, CancellationToken cancellationToken = default)
		{
			var response = await GetOneAgentOnAHostConfigUrl(id)
				.PutJsonAsync(body, cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}

		public async Task<MonitoringConfig> GetOneAgentOnAHostMonitoringConfigAsync(string id, CancellationToken cancellationToken = default)
		{
			var response = await GetOneAgentOnAHostConfigUrl(id)
				.GetJsonWithErrorCheckingAsync<MonitoringConfig>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<bool> UpdateOneAgentOnAHostMonitoringConfigAsync(string id, MonitoringConfig body, CancellationToken cancellationToken = default)
		{
			var response = await GetOneAgentOnAHostConfigUrl(id)
				.PutJsonAsync(body, cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}

		public async Task<TechMonitoringList> GetOneAgentOnAHostTechnologyMonitoringConfigAsync(string id, CancellationToken cancellationToken = default)
		{
			var response = await GetOneAgentOnAHostConfigUrl(id)
				.GetJsonWithErrorCheckingAsync<TechMonitoringList>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}
	}
}
