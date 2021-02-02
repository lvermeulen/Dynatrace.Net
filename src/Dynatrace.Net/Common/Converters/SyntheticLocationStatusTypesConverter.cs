using System.Collections.Generic;
using Dynatrace.Net.Environment.SyntheticV1.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class SyntheticLocationStatusTypesConverter : JsonEnumConverter<SyntheticLocationStatusTypes>
	{
		private static readonly Dictionary<SyntheticLocationStatusTypes, string> s_pairs = new Dictionary<SyntheticLocationStatusTypes, string>
		{
			[SyntheticLocationStatusTypes.Disabled] = "DISABLED",
			[SyntheticLocationStatusTypes.Enabled] = "ENABLED",
			[SyntheticLocationStatusTypes.Hidden] = "HIDDEN"
		};

		protected override Dictionary<SyntheticLocationStatusTypes, string> Pairs { get; } = s_pairs;

		protected override string EntityString { get; } = "location status";
	}
}
