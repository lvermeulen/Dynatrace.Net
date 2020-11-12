using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.ManagementZones.Models
{
	public class ComparisonBasic
	{
		public object Operator	 { get; set; }
		public object Value	 { get; set; }
		public bool? Negate	 { get; set; }
		[JsonConverter(typeof(ComparisonBasicTypesConverter))]
		public ComparisonBasicTypes? Type	 { get; set; }
	}
}
