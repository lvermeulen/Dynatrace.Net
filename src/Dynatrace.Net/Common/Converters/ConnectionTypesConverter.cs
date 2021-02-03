using System.Collections.Generic;
using Dynatrace.Net.Configuration.CalculatedMetrics.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class ConnectionTypesConverter : JsonEnumConverter<ConnectionTypes>
	{
		private static readonly Dictionary<ConnectionTypes, string> s_pairs = new Dictionary<ConnectionTypes, string>
		{
			[ConnectionTypes.Lan] = "LAN",
			[ConnectionTypes.Mobile] = "MOBILE",
			[ConnectionTypes.Offline] = "OFFLINE",
			[ConnectionTypes.Unknown] = "UNKNOWN",
			[ConnectionTypes.Wifi] = "WIFI"
		};

		protected override Dictionary<ConnectionTypes, string> Pairs => s_pairs;

		protected override string EntityString => "connection type";
	}
}
