using System.Collections.Generic;
using Dynatrace.Net.Environment.ServiceLevelObjectives.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class SloErrorTypesConverter : JsonEnumConverter<SloErrorTypes>
	{
		private static readonly Dictionary<SloErrorTypes, string> s_pairs = new Dictionary<SloErrorTypes, string>
		{
			[SloErrorTypes.FilterMatchesInConditionLimitExceeded] = "FILTER_MATCHES_IN_CONDITION_LIMIT_EXCEEDED",
			[SloErrorTypes.InternalError] = "INTERNAL_ERROR",
			[SloErrorTypes.InvalidEntitySelector] = "INVALID_ENTITY_SELECTOR",
			[SloErrorTypes.InvalidMetricDenominator] = "INVALID_METRIC_DENOMINATOR",
			[SloErrorTypes.InvalidMetricNumerator] = "INVALID_METRIC_NUMERATOR",
			[SloErrorTypes.InvalidMetricSelector] = "INVALID_METRIC_SELECTOR",
			[SloErrorTypes.InvalidTimeframe] = "INVALID_TIMEFRAME",
			[SloErrorTypes.MetricsNotResolved] = "METRICS_NOT_RESOLVED",
			[SloErrorTypes.MetricsNoData] = "METRICS_NO_DATA",
			[SloErrorTypes.MetricDenominatorNotResolved] = "METRIC_DENOMINATOR_NOT_RESOLVED",
			[SloErrorTypes.MetricDenominatorNoData] = "METRIC_DENOMINATOR_NO_DATA",
			[SloErrorTypes.MetricDenominatorNoDataPoints] = "METRIC_DENOMINATOR_NO_DATA_POINTS",
			[SloErrorTypes.MetricDenominatorZero] = "METRIC_DENOMINATOR_ZERO",
			[SloErrorTypes.MetricGenericTsmFault] = "METRIC_GENERIC_TSM_FAULT",
			[SloErrorTypes.MetricNumeratorNotResolved] = "METRIC_NUMERATOR_NOT_RESOLVED",
			[SloErrorTypes.MetricNumeratorNoData] = "METRIC_NUMERATOR_NO_DATA",
			[SloErrorTypes.MetricNumeratorNoDataPoints] = "METRIC_NUMERATOR_NO_DATA_POINTS",
			[SloErrorTypes.MetricRateNotResolved] = "METRIC_RATE_NOT_RESOLVED",
			[SloErrorTypes.MetricRateNoData] = "METRIC_RATE_NO_DATA",
			[SloErrorTypes.MetricRateNoDataPoints] = "METRIC_RATE_NO_DATA_POINTS",
			[SloErrorTypes.MetricTooManyResults] = "METRIC_TOO_MANY_RESULTS",
			[SloErrorTypes.None] = "NONE"
		};

		protected override Dictionary<SloErrorTypes, string> Pairs => s_pairs;

		protected override string EntityString => "error";
	}
}
