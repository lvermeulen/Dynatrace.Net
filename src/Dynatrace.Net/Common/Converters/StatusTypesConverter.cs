using System.Collections.Generic;
using Dynatrace.Net.Environment.ServiceLevelObjectives.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class StatusTypesConverter : JsonEnumConverter<StatusTypes>
	{
		private static readonly Dictionary<StatusTypes, string> s_pairs = new Dictionary<StatusTypes, string>
		{
			[StatusTypes.Failure] = "FAILURE",
			[StatusTypes.Success] = "SUCCESS",
			[StatusTypes.Warning] = "WARNING"
		};

		protected override Dictionary<StatusTypes, string> Pairs => s_pairs;

		protected override string EntityString => "status";
	}
}
