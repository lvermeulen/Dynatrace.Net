using System.Collections.Generic;
using Dynatrace.Net.Configuration.AwsCredentials.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class ConnectionStatusTypesConverter : JsonEnumConverter<ConnectionStatusTypes>
	{
		private static readonly Dictionary<ConnectionStatusTypes, string> s_pairs = new Dictionary<ConnectionStatusTypes, string>
		{
			[ConnectionStatusTypes.Connected] = "CONNECTED",
			[ConnectionStatusTypes.Disconnected] = "DISCONNECTED",
			[ConnectionStatusTypes.Uninitialized] = "UNINITIALIZED"
		};

		protected override Dictionary<ConnectionStatusTypes, string> Pairs => s_pairs;
		protected override string EntityString => "connection status";
	}
}
