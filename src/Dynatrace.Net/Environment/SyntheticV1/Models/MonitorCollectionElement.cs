using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Environment.SyntheticV1.Models
{
	public class MonitorCollectionElement
	{
		public string Name { get; set; }
		public string EntityId { get; set; }
		[JsonConverter(typeof(SyntheticMonitorTypesV1Converter))]
		public SyntheticMonitorTypesV1? Type { get; set; }
		public bool? Enabled { get; set; }
	}
}
