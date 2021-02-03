using System.Collections.Generic;
using Dynatrace.Net.Environment.MetricsV2.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class MetricFieldsConverter : JsonEnumConverter<MetricFields>
	{
		private static readonly Dictionary<MetricFields, string> s_pairs = new Dictionary<MetricFields, string>
		{
			[MetricFields.DisplayName] = "displayName",
			[MetricFields.Description] = "description",
			[MetricFields.Unit] = "unit",
			[MetricFields.DduBillable] = "dduBillable",
			[MetricFields.Created] = "created",
			[MetricFields.LastWritten] = "lastWritten",
			[MetricFields.AggregationTypes] = "aggregationTypes",
			[MetricFields.DefaultAggregation] = "defaultAggregation",
			[MetricFields.DimensionDefinitions] = "dimensionDefinitions",
			[MetricFields.Transformations] = "transformations",
			[MetricFields.EntityType] = "entityType"
		};

		protected override Dictionary<MetricFields, string> Pairs => s_pairs;

		protected override string EntityString => "metric field";
	}
}
