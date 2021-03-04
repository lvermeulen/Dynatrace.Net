using System.Collections.Generic;
using Dynatrace.Net.Configuration.Rum.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class UserActionAndSessionPropertyTypesConverter : JsonEnumConverter<UserActionAndSessionPropertyTypes>
	{
		private static readonly Dictionary<UserActionAndSessionPropertyTypes, string> s_pairs = new Dictionary<UserActionAndSessionPropertyTypes, string>
		{
			[UserActionAndSessionPropertyTypes.Date] = "DATE",
			[UserActionAndSessionPropertyTypes.Double] = "DOUBLE",
			[UserActionAndSessionPropertyTypes.Long] = "LONG",
			[UserActionAndSessionPropertyTypes.LongString] = "LONG_STRING",
			[UserActionAndSessionPropertyTypes.String] = "STRING"
		};

		protected override Dictionary<UserActionAndSessionPropertyTypes, string> Pairs => s_pairs;

		protected override string EntityString => "property type";
	}
}
