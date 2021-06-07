using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Common.Converters;
using Dynatrace.Net.Common.Extensions;
using Dynatrace.Net.Environment.Deployment.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private static readonly OneAgentDeploymentOsTypesConverter s_oneAgentDeploymentOsTypesConverter = new OneAgentDeploymentOsTypesConverter();
		private static readonly OneAgentInstallerTypesConverter s_oneAgentInstallerTypesConverter = new OneAgentInstallerTypesConverter();
		private static readonly LinuxDistributionFlavorsConverter s_linuxDistributionFlavorsConverter = new LinuxDistributionFlavorsConverter();
		private static readonly OsArchitectureTypesConverter s_osArchitectureTypesConverter = new OsArchitectureTypesConverter();
		private static readonly OsBitnessTypesConverter s_osBitnessTypesConverter = new OsBitnessTypesConverter();

		private IFlurlRequest GetDeploymentOneAgentUrl()
		{
			return GetBaseUrl()
				.AppendPathSegment("v1/deployment/installer/agent");
		}

		public async Task<bool> DownloadOneAgentLatestAsync(OneAgentDeploymentOsTypes osType, OneAgentInstallerTypes installerType, LinuxDistributionFlavors? flavor = null, OsArchitectureTypes? arch = null,
			OsBitnessTypes? bitness = null, IEnumerable<string> include = null, bool? skipMetadata = false, string ifNoneMatchEtag = null, CancellationToken cancellationToken = default)
		{
			var queryParamValues = new Dictionary<string, object>
			{
				[nameof(flavor)] = s_linuxDistributionFlavorsConverter.ConvertToString(flavor),
				[nameof(arch)] = s_osArchitectureTypesConverter.ConvertToString(arch),
				[nameof(bitness)] = s_osBitnessTypesConverter.ConvertToString(bitness),
				[nameof(include)] = include == null ? null : string.Join("&", include.Select(x => $"include={x}")),
				[nameof(skipMetadata)] = skipMetadata
			};

			var response = await GetDeploymentOneAgentUrl()
				.WithHeader("If-None-Match", ifNoneMatchEtag)
				.AppendPathSegment(s_oneAgentDeploymentOsTypesConverter.ConvertToString(osType))
				.AppendPathSegment(s_oneAgentInstallerTypesConverter.ConvertToString(installerType))
				.AppendPathSegment("latest")
				.SetQueryParams(queryParamValues)
				.GetAsync(cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}

		public async Task<bool> DownloadOneAgentSpecificVersionAsync(OneAgentDeploymentOsTypes osType, OneAgentInstallerTypes installerType, string version, LinuxDistributionFlavors? flavor = null,
			OsArchitectureTypes? arch = null, OsBitnessTypes? bitness = null, IEnumerable<string> include = null, bool? skipMetadata = false, string ifNoneMatchEtag = null,
			CancellationToken cancellationToken = default)
		{
			var queryParamValues = new Dictionary<string, object>
			{
				[nameof(flavor)] = s_linuxDistributionFlavorsConverter.ConvertToString(flavor),
				[nameof(arch)] = s_osArchitectureTypesConverter.ConvertToString(arch),
				[nameof(bitness)] = s_osBitnessTypesConverter.ConvertToString(bitness),
				[nameof(include)] = include == null ? null : string.Join("&", include.Select(x => $"include={x}")),
				[nameof(skipMetadata)] = skipMetadata
			};

			var response = await GetDeploymentOneAgentUrl()
				.WithHeader("If-None-Match", ifNoneMatchEtag)
				.AppendPathSegment(s_oneAgentDeploymentOsTypesConverter.ConvertToString(osType))
				.AppendPathSegment(s_oneAgentInstallerTypesConverter.ConvertToString(installerType))
				.AppendPathSegment("version")
				.AppendPathSegment(version)
				.SetQueryParams(queryParamValues)
				.GetAsync(cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}

		public async Task<Versions> ListOneAgentAvailableVersionsAsync(OneAgentDeploymentOsTypes osType, OneAgentInstallerTypes installerType, LinuxDistributionFlavors? flavor = null, OsArchitectureTypes? arch = null,
			CancellationToken cancellationToken = default)
		{
			var queryParamValues = new Dictionary<string, object>
			{
				[nameof(flavor)] = s_linuxDistributionFlavorsConverter.ConvertToString(flavor),
				[nameof(arch)] = s_osArchitectureTypesConverter.ConvertToString(arch)
			};

			var response = await GetDeploymentOneAgentUrl()
				.AppendPathSegment("versions")
				.AppendPathSegment(s_oneAgentDeploymentOsTypesConverter.ConvertToString(osType))
				.AppendPathSegment(s_oneAgentInstallerTypesConverter.ConvertToString(installerType))
				.SetQueryParams(queryParamValues)
				.GetJsonIfNotEmptyAsync(new Versions(), cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<InstallerMetaInfoDto> ViewOneAgentLatestVersionAsync(OneAgentDeploymentOsTypes osType, OneAgentInstallerTypes installerType, string version, LinuxDistributionFlavors? flavor = null,
			OsArchitectureTypes? arch = null, OsBitnessTypes? bitness = null, CancellationToken cancellationToken = default)
		{
			var queryParamValues = new Dictionary<string, object>
			{
				[nameof(flavor)] = s_linuxDistributionFlavorsConverter.ConvertToString(flavor),
				[nameof(arch)] = s_osArchitectureTypesConverter.ConvertToString(arch),
				[nameof(bitness)] = s_osBitnessTypesConverter.ConvertToString(bitness)
			};

			var response = await GetDeploymentOneAgentUrl()
				.AppendPathSegment(s_oneAgentDeploymentOsTypesConverter.ConvertToString(osType))
				.AppendPathSegment(s_oneAgentInstallerTypesConverter.ConvertToString(installerType))
				.AppendPathSegment("latest")
				.AppendPathSegment("metainfo")
				.SetQueryParams(queryParamValues)
				.GetJsonAsync<InstallerMetaInfoDto>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<ConnectionInfo> ViewOneAgentConnectivityInformationAsync(CancellationToken cancellationToken = default)
		{
			var response = await GetDeploymentOneAgentUrl()
				.AppendPathSegment("connectioninfo")
				.GetJsonAsync<ConnectionInfo>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}
		
		public async Task<string> ViewOneAgentActiveGateEndpointsAsync(CancellationToken cancellationToken = default)
		{
			string response = await GetDeploymentOneAgentUrl()
				.AppendPathSegment("connectioninfo")
				.AppendPathSegment("endpoints")
				.GetStringAsync(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}
	}
}
