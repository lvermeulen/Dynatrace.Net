using System.Collections.Generic;
using Dynatrace.Net.Configuration.Rum.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class UserActionDetailsActionTypesConverter : JsonEnumConverter<UserActionDetailsActionTypes>
	{
		private static readonly Dictionary<UserActionDetailsActionTypes, string> s_pairs = new Dictionary<UserActionDetailsActionTypes, string>
		{
			[UserActionDetailsActionTypes.Custom] = "Custom",
			[UserActionDetailsActionTypes.Load] = "Load",
			[UserActionDetailsActionTypes.Xhr] = "Xhr"
		};

		protected override Dictionary<UserActionDetailsActionTypes, string> Pairs => s_pairs;
		protected override string EntityString => "action type";
	}
}
