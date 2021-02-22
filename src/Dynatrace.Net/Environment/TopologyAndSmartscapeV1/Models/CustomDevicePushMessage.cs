using System.Collections.Generic;

namespace Dynatrace.Net.Environment.TopologyAndSmartscapeV1.Models
{
	public class CustomDevicePushMessage
	{
		public string DisplayName { get; set; }
		public string Group { get; set; }
		public IEnumerable<string> IpAddresses { get; set; }
		public IEnumerable<int> ListenPorts { get; set; }
		public string Type { get; set; }
		public string Favicon { get; set; }
		public string ConfigUrl { get; set; }
		public object Properties { get; set; }
		public IEnumerable<string> Tags { get; set; }
		public IEnumerable<EntityTimeseriesData> Series { get; set; }
		public IEnumerable<string> HostNames { get; set; }
	}
}
