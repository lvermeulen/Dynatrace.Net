using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.Rum.Models
{
	public class UserActionDetails
	{
		public string Value { get; set; }
		public bool? CaseSensitive { get; set; }
		[JsonConverter(typeof(UserActionDetailsMatchTypesConverter))]
		public UserActionDetailsMatchTypes? MatchType { get; set; }
		[JsonConverter(typeof(UserActionDetailsMatchEntitiesConverter))]
		public UserActionDetailsMatchEntities? MatchEntity { get; set; }
		[JsonConverter(typeof(UserActionDetailsActionTypesConverter))]
		public UserActionDetailsActionTypes? ActionType { get; set; }
	}
}
