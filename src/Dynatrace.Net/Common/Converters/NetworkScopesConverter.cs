using System.Collections.Generic;
using Dynatrace.Net.Configuration.RemoteEnvironments.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class NetworkScopesConverter : JsonEnumConverter<NetworkScopes>
	{
		private static readonly Dictionary<NetworkScopes, string> s_pairs = new Dictionary<NetworkScopes, string>
		{
			[NetworkScopes.Cluster] = "CLUSTER",
			[NetworkScopes.External] = "EXTERNAL",
			[NetworkScopes.Internal] = "INTERNAL"
		};

		protected override Dictionary<NetworkScopes, string> Pairs => s_pairs;

		protected override string EntityString => "network scope";
	}
}
