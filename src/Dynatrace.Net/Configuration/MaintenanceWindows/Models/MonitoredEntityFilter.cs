using System.Collections.Generic;
using Dynatrace.Net.Common.Converters;
using Dynatrace.Net.Common.Models;
using Dynatrace.Net.Environment.Events.Models;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.MaintenanceWindows.Models
{
	public class MonitoredEntityFilter
	{
		[JsonConverter(typeof(MeTypesConverter))]
		public MeTypes? Type { get; set; }
		public string MzId { get; set; }
		public IEnumerable<TagInfo> Tags { get; set; }
		[JsonConverter(typeof(TagCombinationTypesConverter))]
		public TagCombinationTypes? TagCombination { get; set; }
	}
}
