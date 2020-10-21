using System.Collections.Generic;
using Dynatrace.Net.Environment.MetricsV2.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class MetricDescriptorAggregationTypesConverter : JsonEnumConverter<MetricDescriptorAggregationTypes>
	{
		private static readonly Dictionary<MetricDescriptorAggregationTypes, string> s_pairs = new Dictionary<MetricDescriptorAggregationTypes, string>
		{
			[MetricDescriptorAggregationTypes.Auto] = "auto",
			[MetricDescriptorAggregationTypes.Avg] = "avg",
			[MetricDescriptorAggregationTypes.Count] = "count",
			[MetricDescriptorAggregationTypes.Max] = "max",
			[MetricDescriptorAggregationTypes.Median] = "median",
			[MetricDescriptorAggregationTypes.Min] = "min",
			[MetricDescriptorAggregationTypes.Percentile] = "percentile",
			[MetricDescriptorAggregationTypes.Sum] = "sum",
			[MetricDescriptorAggregationTypes.Value] = "value"
		};

		protected override Dictionary<MetricDescriptorAggregationTypes, string> Pairs { get; } = s_pairs;

		protected override string EntityString { get; } = "metric descriptor aggregation type";
	}
}
