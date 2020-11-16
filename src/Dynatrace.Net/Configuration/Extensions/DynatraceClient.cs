using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Common.Converters;
using Dynatrace.Net.Common.Models;
using Dynatrace.Net.Configuration.Extensions.Models;
using Dynatrace.Net.Configuration.Services.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private static readonly ExtensionStatesConverter s_extensionStatesConverter = new ExtensionStatesConverter();
		private static readonly ServiceTechnologiesConverter s_serviceTechnologiesConverter = new ServiceTechnologiesConverter();

		private IFlurlRequest GetExtensionsUrl()
		{
			return GetBaseUrl()
				.AppendPathSegment("config/v1/extensions");
		}

		private IFlurlRequest GetExtensionInstancesUrl(string id)
		{
			return GetExtensionsUrl()
				.AppendPathSegment(id)
				.AppendPathSegment("instances");
		}

		private IFlurlRequest GetExtensionGlobalUrl(string id)
		{
			return GetExtensionsUrl()
				.AppendPathSegment(id)
				.AppendPathSegment("global");
		}

		public async Task<ExtensionListDto> GetExtensionsAsync(CancellationToken cancellationToken = default)
		{
			var response = await GetExtensionsUrl()
				.GetJsonAsync<ExtensionListDto>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<Extension> GetExtensionAsync(string id, CancellationToken cancellationToken = default)
		{
			var response = await GetExtensionsUrl()
				.AppendPathSegment(id)
				.GetJsonAsync<Extension>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<ExtensionStateList> GetExtensionStatesAsync(string id, int? pageSize = null, string nextPageKey = null, ExtensionStates? state = null, CancellationToken cancellationToken = default)
		{
			var queryParamValues = new Dictionary<string, object>
			{
				[nameof(pageSize)] = pageSize,
				[nameof(nextPageKey)] = nextPageKey,
				[nameof(state)] = s_extensionStatesConverter.ConvertToString(state)
			};

			var response = await GetExtensionsUrl()
				.AppendPathSegment(id)
				.AppendPathSegment("states")
				.SetQueryParams(queryParamValues)
				.GetJsonAsync<ExtensionStateList>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<EntityShortRepresentation> PostExtensionZipFileAsync(string file, bool? overrideAlerts, CancellationToken cancellationToken = default)
		{
			var response = await GetExtensionsUrl()
				.SetQueryParam(nameof(overrideAlerts), overrideAlerts)
				.PostMultipartAsync(content => content.AddFile(Path.GetFileName(file), Path.GetDirectoryName(file)), cancellationToken)
				.ReceiveJson<EntityShortRepresentation>()
				.ConfigureAwait(false);

			return response;
		}

		public async Task<Stream> GetExtensionZipFileAsync(string id, CancellationToken cancellationToken = default)
		{
			var response = await GetExtensionsUrl()
				.AppendPathSegment(id)
				.AppendPathSegment("binary")
				.GetStreamAsync(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<bool> DeleteExtensionZipFileAsync(string id, CancellationToken cancellationToken = default)
		{
			var response = await GetExtensionsUrl()
				.AppendPathSegment(id)
				.DeleteAsync(cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}

		public async Task<ExtensionConfigurationList> GetExtensionInstancesAsync(string id, int? pageSize = null, string nextPageKey = null, CancellationToken cancellationToken = default)
		{
			var queryParamValues = new Dictionary<string, object>
			{
				[nameof(pageSize)] = pageSize,
				[nameof(nextPageKey)] = nextPageKey
			};

			var response = await GetExtensionInstancesUrl(id)
				.SetQueryParams(queryParamValues)
				.GetJsonAsync<ExtensionConfigurationList>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<ExtensionConfigurationDto> GetExtensionInstanceAsync(string id, string configurationId, CancellationToken cancellationToken = default)
		{
			var response = await GetExtensionInstancesUrl(id)
				.AppendPathSegment(configurationId)
				.GetJsonAsync<ExtensionConfigurationDto>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<ExtensionConfigurationDto> AddExtensionInstanceAsync(string id, ExtensionConfigurationDto body, CancellationToken cancellationToken = default)
		{
			var response = await GetExtensionInstancesUrl(id)
				.PostJsonAsync(body, cancellationToken)
				.ReceiveJson<ExtensionConfigurationDto>()
				.ConfigureAwait(false);

			return response;
		}

		public async Task<bool> UpdateExtensionInstanceAsync(string id, string configurationId, ExtensionConfigurationDto body, CancellationToken cancellationToken = default)
		{
			var response = await GetExtensionInstancesUrl(id)
				.AppendPathSegment(configurationId)
				.PutJsonAsync(body, cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}

		public async Task<bool> DeleteExtensionInstanceAsync(string id, string configurationId, CancellationToken cancellationToken = default)
		{
			var response = await GetExtensionInstancesUrl(id)
				.AppendPathSegment(configurationId)
				.DeleteAsync(cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}

		public async Task<GlobalExtensionConfiguration> GetExtensionGlobalConfigurationAsync(string id, CancellationToken cancellationToken = default)
		{
			var response = await GetExtensionGlobalUrl(id)
				.GetJsonAsync<GlobalExtensionConfiguration>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<bool> UpdateExtensionGlobalConfigurationAsync(string id, GlobalExtensionConfiguration body, CancellationToken cancellationToken = default)
		{
			var response = await GetExtensionGlobalUrl(id)
				.PutJsonAsync(body, cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}

		public async Task<StubList> GetActiveGateExtensionModulesAsync(string id, CancellationToken cancellationToken = default)
		{
			var response = await GetExtensionsUrl()
				.AppendPathSegment("activeGateExtensionModules")
				.GetJsonAsync<StubList>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<HostList> GetExtensionHostsAsync(ServiceTechnologies? technology, IEnumerable<string> tag = null, int? managementZone = null, string hostGroupId = null,
			string hostGroupName = null, int? pageSize = null, string nextPageKey = null, CancellationToken cancellationToken = default)
		{
			var queryParamValues = new Dictionary<string, object>
			{
				[nameof(tag)] = tag == null ? null : string.Join("&", tag.Select(x => $"tag={x}")),
				[nameof(managementZone)] = managementZone,
				[nameof(hostGroupId)] = hostGroupId,
				[nameof(hostGroupName)] = hostGroupName,
				[nameof(pageSize)] = pageSize,
				[nameof(nextPageKey)] = nextPageKey
			};

			var response = await GetExtensionsUrl()
				.AppendPathSegment(s_serviceTechnologiesConverter.ConvertToString(technology))
				.AppendPathSegment("availableHosts")
				.SetQueryParams(queryParamValues)
				.GetJsonAsync<HostList>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}
	}
}
