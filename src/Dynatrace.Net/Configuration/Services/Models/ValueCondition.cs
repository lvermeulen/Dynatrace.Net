using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.Services.Models
{
	public class ValueCondition
	{
		[JsonConverter(typeof(ValueConditionOperatorsConverter))]
		public ValueConditionOperators? Operator { get; set; }
		public bool? Negate { get; set; }
		public string Value { get; set; }
	}
}
