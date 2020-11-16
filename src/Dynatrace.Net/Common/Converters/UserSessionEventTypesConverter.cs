using System.Collections.Generic;
using Dynatrace.Net.Environment.UserSessions.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class UserSessionEventTypesConverter : JsonEnumConverter<UserSessionEventTypes>
	{
		private static readonly Dictionary<UserSessionEventTypes, string> s_pairs = new Dictionary<UserSessionEventTypes, string>
		{
			[UserSessionEventTypes.Behavioral] = "Behavioral",
			[UserSessionEventTypes.Crash] = "Crash",
			[UserSessionEventTypes.Error] = "Error",
			[UserSessionEventTypes.RageClick] = "RageClick",
			[UserSessionEventTypes.UserTag] = "UserTag",
			[UserSessionEventTypes.UserTagFromMetaData] = "UserTagFromMetaData",
			[UserSessionEventTypes.VisitTag] = "VisitTag"
		};
		
		protected override Dictionary<UserSessionEventTypes, string> Pairs { get; } = s_pairs;

		protected override string EntityString { get; } = "user session event type";
	}
}
