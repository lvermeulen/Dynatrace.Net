using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.Services.Models
{
	public class Condition
	{
		[JsonConverter(typeof(ConditionAttributeTypesConverter))]
		public ConditionAttributeTypes? Attribute { get; set; }
		public ComparisonInfo ComparisonInfo { get; set; }
	}
}
