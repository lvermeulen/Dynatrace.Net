using System.Collections.Generic;
using Dynatrace.Net.Common.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class HealthStatesConverter : JsonEnumConverter<HealthStates>
	{
		private static readonly Dictionary<HealthStates, string> s_pairs = new Dictionary<HealthStates, string>
		{
			[HealthStates.Healthy] = "HEALTHY",
			[HealthStates.Unhealthy] = "UNHEALTHY"
		};

		protected override Dictionary<HealthStates, string> Pairs => s_pairs;

		protected override string EntityString => "healthState";
	}
}
