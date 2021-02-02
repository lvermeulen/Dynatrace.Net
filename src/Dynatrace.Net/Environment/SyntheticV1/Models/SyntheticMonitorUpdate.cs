using System.Collections.Generic;

namespace Dynatrace.Net.Environment.SyntheticV1.Models
{
	public class SyntheticMonitorUpdate
	{
		public int? FrequencyMin { get; set; }
		public AnomalyDetection AnomalyDetection { get; set; }
		public string Type { get; set; }
		public string Name { get; set; }
		public IEnumerable<string> Locations { get; set; }
		public bool? Enabled { get; set; }
		public object Script { get; set; }
		public IEnumerable<TagWithSourceInfo> Tags { get; set; }
		public IEnumerable<string> ManuallyAssignedApps { get; set; }
	}
}
