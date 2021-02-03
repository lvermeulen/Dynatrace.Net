using System.Collections.Generic;
using Dynatrace.Net.Environment.UserSessions.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class UserSessionUserActionTypesConverter : JsonEnumConverter<UserSessionUserActionTypes>
	{
		private static readonly Dictionary<UserSessionUserActionTypes, string> s_pairs = new Dictionary<UserSessionUserActionTypes, string>
		{
			[UserSessionUserActionTypes.Custom] = "Custom",
			[UserSessionUserActionTypes.EndVisit] = "EndVisit",
			[UserSessionUserActionTypes.Error] = "Error",
			[UserSessionUserActionTypes.Load] = "Load",
			[UserSessionUserActionTypes.RageClick] = "RageClick",
			[UserSessionUserActionTypes.SyntheticHiddenAction] = "SyntheticHiddenAction",
			[UserSessionUserActionTypes.UserSessionProperties] = "UserSessionProperties",
			[UserSessionUserActionTypes.VisitTag] = "VisitTag",
			[UserSessionUserActionTypes.Xhr] = "Xhr"
		};
		
		protected override Dictionary<UserSessionUserActionTypes, string> Pairs => s_pairs;

		protected override string EntityString => "user action type";
	}
}
