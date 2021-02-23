using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Common.Converters;
using Dynatrace.Net.Configuration.CalculatedMetrics.Models;
using Dynatrace.Net.Configuration.Extensions.Models;
using Dynatrace.Net.Environment.ActiveGates.Models;
using Dynatrace.Net.Environment.OneAgentOnAHost.Models;
using Dynatrace.Net.Environment.ProblemsV1.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private static readonly OsTypesConverter s_osTypesConverter = new OsTypesConverter();
		private static readonly AvailabilityStatesConverter s_availabilityStatesConverter = new AvailabilityStatesConverter();
		private static readonly MonitoringTypesConverter s_monitoringTypesConverter = new MonitoringTypesConverter();
		private static readonly AutoUpdateSettingsConverter s_autoUpdateSettingsConverter = new AutoUpdateSettingsConverter();
		private static readonly TechnologyModuleTypesConverter s_technologyModuleTypesConverter = new TechnologyModuleTypesConverter();

		private IFlurlRequest GetOneAgentOnAHostUrl()
		{
			return GetBaseUrl()
				.AppendPathSegment("v1/oneagents");
		}

		public async Task<HostsListPage> GetOneAgentInstanceConfigurationAsync(int? startTimestamp = null, int? endTimestamp = null, RelativeTimes? relativeTime = null, IEnumerable<string> tag = null,
			IEnumerable<string> entity = null, int? managementZoneId = null, string managementZone = null, string networkZoneId = null, string hostGroupId = null, string hostGroupName = null,
			OsTypes? osType = null, AvailabilityStates? availabilityState = null, MonitoringTypes? monitoringType = null, VersionCompareTypes? agentVersionIs = null, string agentVersionNumber = null,
			AutoUpdateSettings? autoUpdateSetting = null, ActiveGatesUpdateStatusTypes? updateStatus = null, bool? faultyVersion = null, TechnologyModuleTypes? technologyModuleType = null,
			VersionCompareTypes? technologyModuleVersionIs = null, string technologyModuleVersionNumber = null, bool? technologyModuleFaultyVersion = null, string pluginName = null,
			VersionCompareTypes? pluginVersionIs = null, string pluginVersionNumber = null, ExtensionStates? pluginState = null, string nextPageKey = null, CancellationToken cancellationToken = default)
		{
			var queryParamValues = new Dictionary<string, object>
			{
				[nameof(startTimestamp)] = startTimestamp,
				[nameof(endTimestamp)] = endTimestamp,
				[nameof(relativeTime)] = relativeTime?.ToString(), 
				[nameof(tag)] = tag == null ? null : string.Join("&", tag.Select(x => $"tag={x}")),
				[nameof(entity)] = entity == null ? null : string.Join("&", entity.Select(x => $"entity={x}")), 
				[nameof(managementZoneId)] = managementZoneId, 
				[nameof(managementZone)] = managementZone,
				[nameof(networkZoneId)] = networkZoneId,
				[nameof(hostGroupId)] = hostGroupId,
				[nameof(hostGroupName)] = hostGroupName,
				[nameof(osType)] = s_osTypesConverter.ConvertToString(osType),
				[nameof(availabilityState)] = s_availabilityStatesConverter.ConvertToString(availabilityState),
				[nameof(monitoringType)] = s_monitoringTypesConverter.ConvertToString(monitoringType),
				[nameof(agentVersionIs)] = s_versionCompareTypesConverter.ConvertToString(agentVersionIs),
				[nameof(agentVersionNumber)] = agentVersionNumber,
				[nameof(autoUpdateSetting)] = s_autoUpdateSettingsConverter.ConvertToString(autoUpdateSetting),
				[nameof(updateStatus)] = s_activeGatesUpdateStatusTypesConverter.ConvertToString(updateStatus),
				[nameof(faultyVersion)] = faultyVersion,
				[nameof(technologyModuleType)] = s_technologyModuleTypesConverter.ConvertToString(technologyModuleType),
				[nameof(technologyModuleVersionIs)] = s_versionCompareTypesConverter.ConvertToString(technologyModuleVersionIs), 
				[nameof(technologyModuleVersionNumber)] = technologyModuleVersionNumber,
				[nameof(technologyModuleFaultyVersion)] = technologyModuleFaultyVersion,
				[nameof(pluginName)] = pluginName,
				[nameof(pluginVersionIs)] = s_versionCompareTypesConverter.ConvertToString(pluginVersionIs),
				[nameof(pluginVersionNumber)] = pluginVersionNumber,
				[nameof(pluginState)] = s_extensionStatesConverter.ConvertToString(pluginState),
				[nameof(nextPageKey)] = nextPageKey
			};

			var response = await GetOneAgentOnAHostUrl()
				.SetQueryParams(queryParamValues)
				.GetJsonAsync<HostsListPage>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}
	}
}
