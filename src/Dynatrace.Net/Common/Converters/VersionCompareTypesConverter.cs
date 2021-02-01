using System.Collections.Generic;
using Dynatrace.Net.Environment.ActiveGates.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class VersionCompareTypesConverter : JsonEnumConverter<VersionCompareTypes>
	{
		private static readonly Dictionary<VersionCompareTypes, string> s_pairs = new Dictionary<VersionCompareTypes, string>
		{
			[VersionCompareTypes.Equal] = "EQUAL",
			[VersionCompareTypes.Greater] = "GREATER",
			[VersionCompareTypes.GreaterEqual] = "GREATER_EQUAL",
			[VersionCompareTypes.Lower] = "LOWER",
			[VersionCompareTypes.LowerEqual] = "LOWER_EQUAL"
		};

		protected override Dictionary<VersionCompareTypes, string> Pairs { get; } = s_pairs;

		protected override string EntityString { get; } = "version compare type";
	}
}
