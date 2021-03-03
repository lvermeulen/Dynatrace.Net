using System.Collections.Generic;
using Dynatrace.Net.Configuration.Rum.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class MobileSessionUserActionPropertyTypesConverter : JsonEnumConverter<MobileSessionUserActionPropertyTypes>
	{
		private static readonly Dictionary<MobileSessionUserActionPropertyTypes, string> s_pairs = new Dictionary<MobileSessionUserActionPropertyTypes, string>
		{
			[MobileSessionUserActionPropertyTypes.Double] = "DOUBLE",
			[MobileSessionUserActionPropertyTypes.Long] = "LONG",
			[MobileSessionUserActionPropertyTypes.String] = "STRING"
		};

		protected override Dictionary<MobileSessionUserActionPropertyTypes, string> Pairs => s_pairs;

		protected override string EntityString => "mobile session user action property type";
	}
}
