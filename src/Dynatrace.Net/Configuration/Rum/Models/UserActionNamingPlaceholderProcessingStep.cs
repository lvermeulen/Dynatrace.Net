using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.Rum.Models
{
	public class UserActionNamingPlaceholderProcessingStep
	{
		[JsonConverter(typeof(PlaceholderProcessingStepTypesConverter))]
		public PlaceholderProcessingStepTypes? Type { get; set; }
		public string PatternBefore { get; set; }
		[JsonConverter(typeof(PatternSearchTypesConverter))]
		public PatternSearchTypes? PatternBeforeSearchType { get; set; }
		public string PatternAfter { get; set; }
		[JsonConverter(typeof(PatternSearchTypesConverter))]
		public PatternSearchTypes? PatternAfterSearchType { get; set; }
		public string Replacement { get; set; }
		public string PatternToReplace { get; set; }
		public string RegularExpression { get; set; }
		public bool? FallbackToInput { get; set; }
	}
}
