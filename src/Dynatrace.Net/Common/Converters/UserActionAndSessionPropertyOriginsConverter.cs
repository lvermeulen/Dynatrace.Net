using System.Collections.Generic;
using Dynatrace.Net.Configuration.Rum.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class UserActionAndSessionPropertyOriginsConverter : JsonEnumConverter<UserActionAndSessionPropertyOrigins>
	{
		private static readonly Dictionary<UserActionAndSessionPropertyOrigins, string> s_pairs = new Dictionary<UserActionAndSessionPropertyOrigins, string>
		{
			[UserActionAndSessionPropertyOrigins.JavascriptApi] = "JAVASCRIPT_API",
			[UserActionAndSessionPropertyOrigins.MetaData] = "META_DATA",
			[UserActionAndSessionPropertyOrigins.ServerSideRequestAttribute] = "SERVER_SIDE_REQUEST_ATTRIBUTE"
		};

		protected override Dictionary<UserActionAndSessionPropertyOrigins, string> Pairs => s_pairs;

		protected override string EntityString => "origin";
	}
}
