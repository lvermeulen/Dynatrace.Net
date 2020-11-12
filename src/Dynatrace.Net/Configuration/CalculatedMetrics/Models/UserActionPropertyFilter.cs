using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.CalculatedMetrics.Models
{
	public class UserActionPropertyFilter
	{
		public string Key { get; set; }
		public string Value { get; set; }
		public decimal? From { get; set; }
		public decimal? To { get; set; }
		[JsonConverter(typeof(UserActionPropertyFilterMatchTypesConverter))]
		public UserActionPropertyFilterMatchTypes? MatchType { get; set; }
	}
}
