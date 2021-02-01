using System.Collections.Generic;
using Dynatrace.Net.Environment.ActiveGates.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class ActiveGatesTypesConverter : JsonEnumConverter<ActiveGatesTypes>
	{
		private static readonly Dictionary<ActiveGatesTypes, string> s_pairs = new Dictionary<ActiveGatesTypes, string>
		{
			[ActiveGatesTypes.Cluster] = "CLUSTER",
			[ActiveGatesTypes.Environment] = "ENVIRONMENT",
			[ActiveGatesTypes.EnvironmentMulti] = "ENVIRONMENT_MULTI"
		};

		protected override Dictionary<ActiveGatesTypes, string> Pairs { get; } = s_pairs;

		protected override string EntityString { get; } = "type";
	}
}
