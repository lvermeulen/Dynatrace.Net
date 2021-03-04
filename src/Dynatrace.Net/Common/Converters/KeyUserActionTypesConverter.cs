using System.Collections.Generic;
using Dynatrace.Net.Configuration.Rum.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class KeyUserActionTypesConverter : JsonEnumConverter<KeyUserActionTypes>
	{
		private static readonly Dictionary<KeyUserActionTypes, string> s_pairs = new Dictionary<KeyUserActionTypes, string>
		{
			[KeyUserActionTypes.Custom] = "Custom",
			[KeyUserActionTypes.Load] = "Load",
			[KeyUserActionTypes.Xhr] = "Xhr"
		};

		protected override Dictionary<KeyUserActionTypes, string> Pairs => s_pairs;

		protected override string EntityString => "key user action type";
	}
}
