using System.Collections.Generic;
using Dynatrace.Net.Configuration.AnomalyDetection.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class OperatorsConverter : JsonEnumConverter<Operators>
	{
		private static readonly Dictionary<Operators, string> s_pairs = new Dictionary<Operators, string>
		{
			[Operators.Contains] = "CONTAINS",
			[Operators.DoesNotContain] = "DOES_NOT_CONTAIN",
			[Operators.DoesNotEqual] = "DOES_NOT_EQUAL",
			[Operators.DoesNotStartWith] = "DOES_NOT_START_WITH",
			[Operators.Equal] = "EQUALS",
			[Operators.StartsWith] = "STARTS_WITH"
		};

		protected override Dictionary<Operators, string> Pairs => s_pairs;

		protected override string EntityString => "operator";
	}
}
