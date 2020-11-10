using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.Services.Models
{
	public class ComparisonInfo
	{
		public object Comparison { get; set; }
		public object Value { get; set; }
		public bool? Negate { get; set; }
		[JsonConverter(typeof(ComparisonInfoTypesConverter))]
		public ComparisonInfoTypes? Type { get; set; }
	}
}
