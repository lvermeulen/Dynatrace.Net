using System.Collections.Generic;
using Dynatrace.Net.Environment.ServiceLevelObjectives.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class EvaluationTypesConverter : JsonEnumConverter<EvaluationTypes>
	{
		private static readonly Dictionary<EvaluationTypes, string> s_pairs = new Dictionary<EvaluationTypes, string>
		{
			[EvaluationTypes.Aggregate] = "AGGREGATE"
		};

		protected override Dictionary<EvaluationTypes, string> Pairs => s_pairs;

		protected override string EntityString => "evaluation type";
	}
}
