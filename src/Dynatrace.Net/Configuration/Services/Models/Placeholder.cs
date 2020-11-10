using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.Services.Models
{
	public class Placeholder
	{
		public string Name { get; set; }
		[JsonConverter(typeof(ConditionAttributeTypesConverter))]
		public ConditionAttributeTypes? Attribute { get; set; }
		[JsonConverter(typeof(PlaceholderKindsConverter))]
		public PlaceholderKinds? Kind { get; set; }
		public string DelimiterOrRegex { get; set; }
		public string EndDelimiter { get; set; }
		public string RequestAttribute { get; set; }
		[JsonConverter(typeof(PlaceholderNormalizationsConverter))]
		public PlaceholderNormalizations? Normalization { get; set; }
		public bool? UseFromChildCalls { get; set; }
		[JsonConverter(typeof(PlaceHolderAggregationTypesConverter))]
		public PlaceHolderAggregationTypes? Aggregation { get; set; }
		public PropagationSource Source { get; set; }
	}
}
