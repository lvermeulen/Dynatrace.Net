using System.Collections.Generic;
using Dynatrace.Net.Environment.MetricsV2.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class MetricDimensionDefinitionTypesConverter : JsonEnumConverter<MetricDimensionDefinitionTypes>
	{
		private static readonly Dictionary<MetricDimensionDefinitionTypes, string> s_pairs = new Dictionary<MetricDimensionDefinitionTypes, string>
		{
			[MetricDimensionDefinitionTypes.Entity] = "ENTITY",
			[MetricDimensionDefinitionTypes.Number] = "NUMBER",
			[MetricDimensionDefinitionTypes.Other] = "OTHER",
			[MetricDimensionDefinitionTypes.String] = "STRING",
			[MetricDimensionDefinitionTypes.Void] = "VOID"
		};

		protected override Dictionary<MetricDimensionDefinitionTypes, string> Pairs { get; } = s_pairs;

		protected override string EntityString { get; } = "metric dimension definition type";
	}
}
