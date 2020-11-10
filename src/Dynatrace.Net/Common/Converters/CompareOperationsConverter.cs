using System.Collections.Generic;
using Dynatrace.Net.Configuration.Services.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class CompareOperationsConverter : JsonEnumConverter<CompareOperations>
	{
		private static readonly Dictionary<CompareOperations, string> s_pairs = new Dictionary<CompareOperations, string>
		{
			[CompareOperations.EndsWith] = "ENDS_WITH",
			[CompareOperations.Equal] = "EQUALS",
			[CompareOperations.Exists] = "EXISTS",
			[CompareOperations.GreaterThan] = "GREATER_THAN",
			[CompareOperations.IntEquals] = "INT_EQUALS",
			[CompareOperations.IpInRange] = "IP_IN_RANGE",
			[CompareOperations.LessThan] = "LESS_THAN",
			[CompareOperations.StartsWith] = "STARTS_WITH",
			[CompareOperations.StringContains] = "STRING_CONTAINS",
			[CompareOperations.StringEquals] = "STRING_EQUALS",
			[CompareOperations.Tag] = "TAG"
		};

		protected override Dictionary<CompareOperations, string> Pairs { get; } = s_pairs;

		protected override string EntityString { get; } = "compare operation";
	}
}
