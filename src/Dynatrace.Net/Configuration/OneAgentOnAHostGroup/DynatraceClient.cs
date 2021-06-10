using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Common.Extensions;
using Dynatrace.Net.Configuration.OneAgentOnAHostGroup.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private IFlurlRequest GetOneAgentOnAHostGroupConfigUrl(string id)
		{
			return GetBaseUrl()
				.AppendPathSegment($"config/v1/hostgroups/{id}/autoupdate");
		}

		public async Task<HostGroupAutoUpdateConfig> GetOneAgentOnAHostGroupAutoUpdateConfigAsync(string id, CancellationToken cancellationToken = default)
		{
			var response = await GetOneAgentOnAHostGroupConfigUrl(id)
				.GetJsonWithErrorCheckingAsync<HostGroupAutoUpdateConfig>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<bool> UpdateOneAgentOnAHostGroupAutoUpdateConfigAsync(string id, HostGroupAutoUpdateConfig body, CancellationToken cancellationToken = default)
		{
			var response = await GetOneAgentOnAHostGroupConfigUrl(id)
				.PutJsonAsync(body, cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}
	}
}
