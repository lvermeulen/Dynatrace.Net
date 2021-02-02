using System.Collections.Generic;
using Dynatrace.Net.Environment.SyntheticV1.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class StateModificationsConverter : JsonEnumConverter<StateModifications>
	{
		private static readonly Dictionary<StateModifications, string> s_pairs = new Dictionary<StateModifications, string>
		{
			[StateModifications.Active] = "ACTIVE",
			[StateModifications.Hidden] = "HIDDEN",
			[StateModifications.Inactive] = "INACTIVE"
		};

		protected override Dictionary<StateModifications, string> Pairs { get; } = s_pairs;

		protected override string EntityString { get; } = "state modification";
	}
}
