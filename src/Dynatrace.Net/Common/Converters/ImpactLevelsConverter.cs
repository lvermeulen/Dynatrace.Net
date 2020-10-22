using System.Collections.Generic;
using Dynatrace.Net.Common.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class ImpactLevelsConverter : JsonEnumConverter<ImpactLevels>
	{
		private static readonly Dictionary<ImpactLevels, string> s_pairs = new Dictionary<ImpactLevels, string>
		{
			[ImpactLevels.Application] = "APPLICATION",
			[ImpactLevels.Environment] = "ENVIRONMENT",
			[ImpactLevels.Infrastructure] = "INFRASTRUCTURE",
			[ImpactLevels.Service] = "SERVICE"
		};

		protected override Dictionary<ImpactLevels, string> Pairs { get; } = s_pairs;

		protected override string EntityString { get; } = "impactLevel";
	}
}
