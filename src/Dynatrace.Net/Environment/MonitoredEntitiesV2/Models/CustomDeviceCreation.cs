using System.Collections.Generic;
using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Environment.MonitoredEntitiesV2.Models
{
	public class CustomDeviceCreation
	{
		public string CustomDeviceId { get; set; }
		public string DisplayName { get; set; }
		public string Group { get; set; }
		public IEnumerable<string> IpAddresses { get; set; }
		public IEnumerable<int> ListenPorts { get; set; }
		public string Type { get; set; }
		public string FaviconUrl { get; set; }
		public string ConfigUrl { get; set; }
		public object Properties { get; set; }
		public IEnumerable<string> DnsNames { get; set; }
		[JsonConverter(typeof(MessageTypesConverter))]
		public MessageTypes? MessageType { get; set; }
	}
}
