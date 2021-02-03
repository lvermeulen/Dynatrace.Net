using System.Collections.Generic;
using Dynatrace.Net.Configuration.CalculatedMetrics.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class PathDefinitionTypesConverter : JsonEnumConverter<PathDefinitionTypes>
	{
		private static readonly Dictionary<PathDefinitionTypes, string> s_pairs = new Dictionary<PathDefinitionTypes, string>
		{
			[PathDefinitionTypes.Fixed] = "FIXED",
			[PathDefinitionTypes.Wildcard] = "WILDCARD"
		};

		protected override Dictionary<PathDefinitionTypes, string> Pairs => s_pairs;

		protected override string EntityString => "path definition type";
	}
}
