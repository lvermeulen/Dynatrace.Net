using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Common.Extensions;
using Dynatrace.Net.Common.Models;
using Dynatrace.Net.Configuration.Plugins.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private IFlurlRequest GetPluginsUrl()
		{
			return GetBaseUrl()
				.AppendPathSegment("config/v1/plugins");
		}

		public async Task<StubList> GetAllPluginsAsync(CancellationToken cancellationToken = default)
		{
			var response = await GetPluginsUrl()
				.GetJsonWithErrorCheckingAsync<StubList>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<Plugin> GetPluginAsync(string id, CancellationToken cancellationToken = default)
		{
			var response = await GetPluginsUrl()
				.AppendPathSegment(id)
				.GetJsonWithErrorCheckingAsync<Plugin>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<PluginStateList> GetPluginStatesAsync(string id, CancellationToken cancellationToken = default)
		{
			var response = await GetPluginsUrl()
				.AppendPathSegment(id)
				.GetJsonWithErrorCheckingAsync<PluginStateList>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<EntityShortRepresentation> UploadZipPluginFileAsync(byte[] file, bool? overrideAlerts = null, CancellationToken cancellationToken = default)
		{
			var result = await GetPluginsUrl()
				.SetQueryParam(nameof(overrideAlerts), overrideAlerts)
				.PostJsonAsync(new ByteArrayContent(file), cancellationToken)
				.ReceiveJsonWithErrorChecking<EntityShortRepresentation>()
				.ConfigureAwait(false);

			return result;
		}

		public async Task<byte[]> GetZipPluginFileAsync(string id, CancellationToken cancellationToken = default)
		{
			byte[] result = await GetPluginsUrl()
				.AppendPathSegment(id)
				.AppendPathSegment("binary")
				.GetBytesAsync(cancellationToken)
				.ConfigureAwait(false);

			return result;
		}

		public async Task<bool> DeleteZipPluginFileAsync(string id, CancellationToken cancellationToken = default)
		{
			var result = await GetPluginsUrl()
				.AppendPathSegment(id)
				.AppendPathSegment("binary")
				.DeleteAsync(cancellationToken)
				.ConfigureAwait(false);

			return result.IsSuccessStatusCode;
		}

		public async Task<StubList> GetPluginEndpointsAsync(string id, CancellationToken cancellationToken = default)
		{
			var response = await GetPluginsUrl()
				.AppendPathSegment(id)
				.AppendPathSegment("endpoints")
				.GetJsonWithErrorCheckingAsync<StubList>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<RemotePluginEndpoint> GetPluginEndpointAsync(string id, string endpointId, CancellationToken cancellationToken = default)
		{
			var result = await GetPluginsUrl()
				.AppendPathSegment(id)
				.AppendPathSegment("endpoints")
				.AppendPathSegment(endpointId)
				.GetJsonWithErrorCheckingAsync<RemotePluginEndpoint>(cancellationToken)
				.ConfigureAwait(false);

			return result;
		}

		public async Task<EntityShortRepresentation> CreatePluginEndpointAsync(string id, RemotePluginEndpoint body, CancellationToken cancellationToken = default)
		{
			var result = await GetPluginsUrl()
				.AppendPathSegment(id)
				.AppendPathSegment("endpoints")
				.PostJsonAsync(body, cancellationToken)
				.ReceiveJsonWithErrorChecking<EntityShortRepresentation>()
				.ConfigureAwait(false);

			return result;
		}

		public async Task<bool> UpdatePluginEndpointAsync(string id, string endpointId, RemotePluginEndpoint body, CancellationToken cancellationToken = default)
		{
			var response = await GetPluginsUrl()
				.AppendPathSegment(id)
				.AppendPathSegment("endpoints")
				.AppendPathSegment(endpointId)
				.PutJsonAsync(body, cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}

		public async Task<bool> DeletePluginEndpointAsync(string id, string endpointId, CancellationToken cancellationToken = default)
		{
			var response = await GetPluginsUrl()
				.AppendPathSegment(id)
				.AppendPathSegment("endpoints")
				.AppendPathSegment(endpointId)
				.DeleteAsync(cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}

		public async Task<StubList> GetAllActiveGatePluginModulesAsync(CancellationToken cancellationToken = default)
		{
			var response = await GetPluginsUrl()
				.AppendPathSegment("activeGatePluginModules")
				.GetJsonWithErrorCheckingAsync<StubList>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}
	}
}
