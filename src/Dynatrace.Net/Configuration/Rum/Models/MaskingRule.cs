using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.Rum.Models
{
	public class MaskingRule
	{
		[JsonConverter(typeof(MaskingRuleTypesConverter))]
		public MaskingRuleTypes? MaskingRuleType { get; set; }
		public string Selector { get; set; }
		public bool? UserInteractionHidden { get; set; }
	}
}
