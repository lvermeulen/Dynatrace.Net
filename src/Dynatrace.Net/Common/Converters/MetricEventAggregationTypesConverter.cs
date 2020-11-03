using System.Collections.Generic;
using Dynatrace.Net.Configuration.AnomalyDetection.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class MetricEventAggregationTypesConverter : JsonEnumConverter<MetricEventAggregationTypes>
	{
		private static readonly Dictionary<MetricEventAggregationTypes, string> s_pairs = new Dictionary<MetricEventAggregationTypes, string>
		{
			[MetricEventAggregationTypes.Avg] = "AVG",
			[MetricEventAggregationTypes.Count] = "COUNT",
			[MetricEventAggregationTypes.Max] = "MAX",
			[MetricEventAggregationTypes.Median] = "MEDIAN",
			[MetricEventAggregationTypes.Min] = "MIN",
			[MetricEventAggregationTypes.P90] = "P90",
			[MetricEventAggregationTypes.Sum] = "SUM",
			[MetricEventAggregationTypes.Value] = "VALUE"
		};

		protected override Dictionary<MetricEventAggregationTypes, string> Pairs { get; } = s_pairs;

		protected override string EntityString { get; } = "metric event aggregation type";
	}
}
