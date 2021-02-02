using System.Collections.Generic;
using Dynatrace.Net.Common.Converters;
using Dynatrace.Net.Configuration.Extensions.Models;
using Dynatrace.Net.Environment.ActiveGates.Models;
using Newtonsoft.Json;

namespace Dynatrace.Net.Environment.OneAgentOnAHost.Models
{
	public class HostAgentInfo
	{
		public Host HostInfo { get; set; }
		public bool? FaultyVersion { get; set; }
		public bool? Active { get; set; }
		[JsonConverter(typeof(MonitoringModesConverter))]
		public MonitoringModes? ConfiguredMonitoringMode { get; set; }
		[JsonConverter(typeof(MonitoringTypesConverter))]
		public MonitoringTypes? MonitoringType { get; set; }
		[JsonConverter(typeof(AutoUpdateSettingsConverter))]
		public AutoUpdateSettings? AutoUpdateSetting { get; set; }
		[JsonConverter(typeof(ActiveGatesUpdateStatusTypesConverter))]
		public ActiveGatesUpdateStatusTypes? UpdateStatus { get; set; }
		public IEnumerable<string> AvailableVersions { get; set; }
		public bool? ConfiguredMonitoringEnabled { get; set; }
		[JsonConverter(typeof(AvailabilityStatesConverter))]
		public AvailabilityStates? AvailabilityState { get; set; }
		public int? CurrentActiveGateId { get; set; }
		public string CurrentNetworkZoneId { get; set; }
		public IEnumerable<ModuleInfo> Modules { get; set; }
		public IEnumerable<PluginInfo> Plugins { get; set; }
	}
}
