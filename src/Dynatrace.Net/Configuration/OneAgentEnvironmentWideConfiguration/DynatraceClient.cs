using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Common.Extensions;
using Dynatrace.Net.Configuration.OneAgentEnvironmentWideConfiguration.Models;
using Dynatrace.Net.Configuration.OneAgentOnAHost.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private IFlurlRequest GetOneAgentEnvironmentWideAutoUpdateUrl()
		{
			return GetBaseUrl()
				.AppendPathSegment("config/v1/hosts/autoupdate");
		}

		private IFlurlRequest GetOneAgentEnvironmentWideTechnologyMonitoringUrl()
		{
			return GetBaseUrl()
				.AppendPathSegment("config/v1/technologies");
		}

		public async Task<EnvironmentAutoUpdateConfig> GetOneAgentEnvironmentWideAutoUpdateConfigAsync(CancellationToken cancellationToken = default)
		{
			var response = await GetOneAgentEnvironmentWideAutoUpdateUrl()
				.GetJsonWithErrorCheckingAsync<EnvironmentAutoUpdateConfig>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<bool> UpdateOneAgentEnvironmentWideAutoUpdateConfigAsync(EnvironmentAutoUpdateConfig body, CancellationToken cancellationToken = default)
		{
			var response = await GetOneAgentEnvironmentWideAutoUpdateUrl()
				.PutJsonAsync(body, cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}

		public async Task<TechMonitoringList> GetOneAgentEnvironmentWideTechnologyMonitoringConfigAsync(CancellationToken cancellationToken = default)
		{
			var response = await GetOneAgentEnvironmentWideTechnologyMonitoringUrl()
				.GetJsonWithErrorCheckingAsync<TechMonitoringList>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}
	}
}
