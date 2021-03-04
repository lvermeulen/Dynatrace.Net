using Dynatrace.Net.Common.Converters;
using Dynatrace.Net.Configuration.Services.Models;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.Rum.Models
{
	public class HttpErrorRule
	{
		public bool? ConsiderUnknownErrorCode { get; set; }
		public bool? ConsiderBlockedRequests { get; set; }
		public string ErrorCodes { get; set; }
		public bool? FilterByUrl { get; set; }
		[JsonConverter(typeof(ValueConditionOperatorsConverter))]
		public ValueConditionOperators? Filter { get; set; }
		public string Url { get; set; }
		public bool? Capture { get; set; }
		public bool? ImpactApdex { get; set; }
		public bool? ConsiderForAi { get; set; }
	}
}