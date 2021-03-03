using System.Collections.Generic;
using Dynatrace.Net.Configuration.Rum.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class MobileSessionUserActionPropertyOriginsConverter : JsonEnumConverter<MobileSessionUserActionPropertyOrigins>
	{
		private static readonly Dictionary<MobileSessionUserActionPropertyOrigins, string> s_pairs = new Dictionary<MobileSessionUserActionPropertyOrigins, string>
		{
			[MobileSessionUserActionPropertyOrigins.Api] = "API",
			[MobileSessionUserActionPropertyOrigins.ServerSideRequestAttribute] = "SERVER_SIDE_REQUEST_ATTRIBUTE"
		};

		protected override Dictionary<MobileSessionUserActionPropertyOrigins, string> Pairs => s_pairs;

		protected override string EntityString => "mobile session user action property origin";
	}
}
