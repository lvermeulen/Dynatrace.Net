using System.Collections.Generic;
using Dynatrace.Net.Common.Converters;
using Dynatrace.Net.Common.Models;
using Dynatrace.Net.Configuration.AlertingProfiles.Models;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.AnomalyDetection.Models
{
	public class DiskEventAnomalyDetectionConfig
	{
		public ConfigurationMetadata Metadata { get; set; }
		public string Id { get; set; }
		public string Name { get; set; }
		public bool? Enabled { get; set; }
		[JsonConverter(typeof(DiskNameMetricTypesConverter))]
		public DiskNameMetricTypes? Metric { get; set; }
		public decimal? Threshold { get; set; }
		public int? Samples { get; set; }
		public int? ViolatingSamples { get; set; }
		public DiskNameFilter DiskNameFilter { get; set; }
		public IEnumerable<TagFilter> TagFilters { get; set; }
		public string HostGroupId { get; set; }
	}
}
