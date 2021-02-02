using System.Collections.Generic;
using Dynatrace.Net.Environment.SyntheticV1.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class ReleaseStagesConverter : JsonEnumConverter<ReleaseStages>
	{
		private static readonly Dictionary<ReleaseStages, string> s_pairs = new Dictionary<ReleaseStages, string>
		{
			[ReleaseStages.Beta] = "BETA",
			[ReleaseStages.ComingSoon] = "COMING_SOON",
			[ReleaseStages.Ga] = "GA"
		};

		protected override Dictionary<ReleaseStages, string> Pairs { get; } = s_pairs;

		protected override string EntityString { get; } = "release stage";
	}
}
