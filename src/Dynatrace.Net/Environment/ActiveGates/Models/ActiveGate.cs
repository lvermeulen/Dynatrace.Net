using System.Collections.Generic;
using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Environment.ActiveGates.Models
{
	public class ActiveGate
	{
		public string Id { get; set; }
		public IEnumerable<string> NetworkAddresses { get; set; }
		[JsonConverter(typeof(ActiveGatesOsTypesConverter))]
		public ActiveGatesOsTypes? OsType { get; set; }
		[JsonConverter(typeof(ActiveGatesUpdateStatusTypesConverter))]
		public ActiveGatesUpdateStatusTypes? AutoUpdateStatus { get; set; }
		public int? OfflineSince { get; set; }
		public string Version { get; set; }
		[JsonConverter(typeof(ActiveGatesTypesConverter))]
		public ActiveGatesTypes? Type { get; set; }
		public string Hostname { get; set; }
		public string MainEnvironment { get; set; }
		public IEnumerable<string> Environments { get; set; }
		public string NetworkZone { get; set; }
		public string Group { get; set; }
	}
}
