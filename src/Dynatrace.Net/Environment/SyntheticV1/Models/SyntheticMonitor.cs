using System.Collections.Generic;
using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Environment.SyntheticV1.Models
{
	public class SyntheticMonitor
	{
		public string EntityId { get; set; }
		public string Name { get; set; }
		public int? FrequencyMin { get; set; }
		public bool? Enabled { get; set; }
		[JsonConverter(typeof(SyntheticMonitorTypesV1Converter))]
		public SyntheticMonitorTypesV1? Type { get; set; }
		[JsonConverter(typeof(CreatedFromTypesConverter))]
		public CreatedFromTypes? CreatedFrom { get; set; }
		public object Script { get; set; }
		public IEnumerable<string> Locations { get; set; }
		public AnomalyDetection AnomalyDetection { get; set; }
		public IEnumerable<TagWithSourceInfo> Tags { get; set; }
		public IEnumerable<ManagementZoneDto> ManagementZones { get; set; }
		public IEnumerable<string> AutomaticallyAssignedApps { get; set; }
		public IEnumerable<string> ManuallyAssignedApps { get; set; }
	}
}
