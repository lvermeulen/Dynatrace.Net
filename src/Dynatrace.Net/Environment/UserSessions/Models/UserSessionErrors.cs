using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Environment.UserSessions.Models
{
	public class UserSessionErrors
	{
		[JsonConverter(typeof(UserSessionEventTypesConverter))]
		public UserSessionEventTypes? Type { get; set; }
		public string Name { get; set; }
		public string Domain { get; set; }
		public int? StartTime { get; set; }
		public string Application { get; set; }
		public string InternalApplicationId { get; set; }
	}
}
