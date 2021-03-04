using Dynatrace.Net.Common.Converters;
using Dynatrace.Net.Configuration.Services.Models;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.Rum.Models
{
	public class CustomErrorRule
	{
		public string KeyPattern { get; set; }
		[JsonConverter(typeof(ValueConditionOperatorsConverter))]
		public ValueConditionOperators? KeyMatcher { get; set; }
		public string ValuePattern { get; set; }
		[JsonConverter(typeof(ValueConditionOperatorsConverter))]
		public ValueConditionOperators? ValueMatcher { get; set; }
		public bool? Capture { get; set; }
		public bool? ImpactApdex { get; set; }
		public bool? CustomAlerting { get; set; }
	}
}