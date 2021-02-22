using System.Collections.Generic;
using Dynatrace.Net.Environment.TopologyAndSmartscapeV1.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class HostBitnessTypesConverter : JsonEnumConverter<HostBitnessTypes>
	{
		private static readonly Dictionary<HostBitnessTypes, string> s_pairs = new Dictionary<HostBitnessTypes, string>
		{
			[HostBitnessTypes._32bit] = "32bit",
			[HostBitnessTypes._64bit] = "64bit"
		};

		protected override Dictionary<HostBitnessTypes, string> Pairs => s_pairs;

		protected override string EntityString => "host bitness type";
	}
}
