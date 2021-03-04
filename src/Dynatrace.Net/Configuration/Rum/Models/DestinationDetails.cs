using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.Rum.Models
{
	public class DestinationDetails
	{
		public string UrlOrPath { get; set; }
		[JsonConverter(typeof(UserActionDetailsMatchTypesConverter))]
		public UserActionDetailsMatchTypes? MatchType { get; set; }
		public bool? CaseSensitive { get; set; }
	}
}
