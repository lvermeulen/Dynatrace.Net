using System.Collections.Generic;
using Dynatrace.Net.Configuration.CalculatedMetrics.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class ColumnDefinitionTypesConverter : JsonEnumConverter<ColumnDefinitionTypes>
	{
		private static readonly Dictionary<ColumnDefinitionTypes, string> s_pairs = new Dictionary<ColumnDefinitionTypes, string>
		{
			[ColumnDefinitionTypes.Custom] = "CUSTOM",
			[ColumnDefinitionTypes.Json] = "JSON"
		};

		protected override Dictionary<ColumnDefinitionTypes, string> Pairs { get; } = s_pairs;
		protected override string EntityString { get; } = "column definition type";
	}
}
