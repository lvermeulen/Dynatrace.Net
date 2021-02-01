using System.Collections.Generic;
using Dynatrace.Net.Environment.Deployment.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class OsBitnessTypesConverter : JsonEnumConverter<OsBitnessTypes>
	{
		private static readonly Dictionary<OsBitnessTypes, string> s_pairs = new Dictionary<OsBitnessTypes, string>
		{
			[OsBitnessTypes._32] = "32",
			[OsBitnessTypes._64] = "64",
			[OsBitnessTypes.All] = "all"
		};

		protected override Dictionary<OsBitnessTypes, string> Pairs { get; } = s_pairs;

		protected override string EntityString { get; } = "OS bitness";
	}
}
