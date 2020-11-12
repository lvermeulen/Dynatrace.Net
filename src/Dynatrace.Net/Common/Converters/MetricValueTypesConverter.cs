using System.Collections.Generic;
using Dynatrace.Net.Configuration.CalculatedMetrics.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class MetricValueTypesConverter : JsonEnumConverter<MetricValueTypes>
	{
		private static readonly Dictionary<MetricValueTypes, string> s_pairs = new Dictionary<MetricValueTypes, string>
		{
			[MetricValueTypes.FpColumnAvg] = "FP_COLUMN_AVG",
			[MetricValueTypes.FpColumnCount] = "FP_COLUMN_COUNT",
			[MetricValueTypes.FpColumnMax] = "FP_COLUMN_MAX",
			[MetricValueTypes.FpColumnMin] = "FP_COLUMN_MIN",
			[MetricValueTypes.FpColumnSum] = "FP_COLUMN_SUM",
			[MetricValueTypes.FpColumnTopXAvg] = "FP_COLUMN_TOP_X_AVG",
			[MetricValueTypes.FpColumnTopXCount] = "FP_COLUMN_TOP_X_COUNT",
			[MetricValueTypes.FpColumnTopXMax] = "FP_COLUMN_TOP_X_MAX",
			[MetricValueTypes.FpColumnTopXMin] = "FP_COLUMN_TOP_X_MIN",
			[MetricValueTypes.FpColumnTopXSum] = "FP_COLUMN_TOP_X_SUM",
			[MetricValueTypes.IntColumnAvg] = "INT_COLUMN_AVG",
			[MetricValueTypes.IntColumnCount] = "INT_COLUMN_COUNT",
			[MetricValueTypes.IntColumnMax] = "INT_COLUMN_MAX",
			[MetricValueTypes.IntColumnMin] = "INT_COLUMN_MIN",
			[MetricValueTypes.IntColumnSum] = "INT_COLUMN_SUM",
			[MetricValueTypes.IntColumnTopXAvg] = "INT_COLUMN_TOP_X_AVG",
			[MetricValueTypes.IntColumnTopXCount] = "INT_COLUMN_TOP_X_COUNT",
			[MetricValueTypes.IntColumnTopXMax] = "INT_COLUMN_TOP_X_MAX",
			[MetricValueTypes.IntColumnTopXMin] = "INT_COLUMN_TOP_X_MIN",
			[MetricValueTypes.IntColumnTopXSum] = "INT_COLUMN_TOP_X_SUM",
			[MetricValueTypes.Occurrences] = "OCCURRENCES"
		};
		
		protected override Dictionary<MetricValueTypes, string> Pairs { get; } = s_pairs;
		protected override string EntityString { get; } = "metric value type";
	}
}
