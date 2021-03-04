using System.Collections.Generic;
using Dynatrace.Net.Configuration.Rum.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class UserActionDetailsMatchTypesConverter : JsonEnumConverter<UserActionDetailsMatchTypes>
	{
		private static readonly Dictionary<UserActionDetailsMatchTypes, string> s_pairs = new Dictionary<UserActionDetailsMatchTypes, string>
		{
			[UserActionDetailsMatchTypes.Begins] = "Begins",
			[UserActionDetailsMatchTypes.Contains] = "Contains",
			[UserActionDetailsMatchTypes.Ends] = "Ends"
		};

		protected override Dictionary<UserActionDetailsMatchTypes, string> Pairs => s_pairs;

		protected override string EntityString => "match type";
	}
}
