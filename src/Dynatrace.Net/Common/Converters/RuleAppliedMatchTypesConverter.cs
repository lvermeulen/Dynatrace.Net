using System.Collections.Generic;
using Dynatrace.Net.Environment.TopologyAndSmartscapeV1.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class RuleAppliedMatchTypesConverter : JsonEnumConverter<RuleAppliedMatchTypes>
	{
		private static readonly Dictionary<RuleAppliedMatchTypes, string> s_pairs = new Dictionary<RuleAppliedMatchTypes, string>
		{
			[RuleAppliedMatchTypes.AllUrlsAndDomains] = "ALL_URLS_AND_DOMAINS",
			[RuleAppliedMatchTypes.Contains] = "CONTAINS",
			[RuleAppliedMatchTypes.Ends] = "ENDS",
			[RuleAppliedMatchTypes.Equal] = "EQUALS",
			[RuleAppliedMatchTypes.Matches] = "MATCHES",
			[RuleAppliedMatchTypes.Starts] = "STARTS"
		};

		protected override Dictionary<RuleAppliedMatchTypes, string> Pairs => s_pairs;

		protected override string EntityString => "rule applied match type";
	}
}
